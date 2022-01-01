using System.Collections.Generic;
using System.Threading.Tasks;
using MyMusic.Core;
using MyMusic.Core.Models;
using MyMusic.Core.Services;

namespace MyMusic.Service
{
    public class MusicService : IMusicService
    {
        private readonly IUnitOfWork _unitofWork;

        public MusicService(IUnitOfWork unitofWork)
        {
            this._unitofWork = unitofWork;
        }
        public async Task<Music> CreateMusic(Music newMusic)
        {
            await _unitofWork.Music.AddAsync(newMusic); 
            await _unitofWork.CommitAsync();
            return newMusic;
        }

        public async Task DeleteMusic(Music music)
        {
            _unitofWork.Music.RemoveAsync(music);
            await _unitofWork.CommitAsync();
        }

        public async Task<IEnumerable<Music>> GetAllWithArtist()
        {
            return await _unitofWork.Music.GetAllWithArtistAsync();
        }

        public async Task<Music> GetMusicById(int id)
        {
            return await _unitofWork.Music.GetWithArtistByIdAsync(id);
        }

        public async Task<IEnumerable<Music>> GetMusicsByArtistId(int artistId)
        {
            return await _unitofWork.Music.GetAllWithArtistByIdAsync(artistId);
        }

        public async Task UpdateMusic(Music musicToBeUpdated, Music music)
        {
            musicToBeUpdated.Name = music.Name;
            musicToBeUpdated.ArtistId = music.ArtistId;

            await _unitofWork.CommitAsync();
        }
    }
}