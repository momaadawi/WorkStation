using System.Collections.Generic;
using System.Threading.Tasks;
using MyMusic.Core;
using MyMusic.Core.Models;
using MyMusic.Core.Services;

namespace MyMusic.Service
{
    public class ArtistService : IArtistService
    {
        public IUnitOfWork _unitOfWork { get; }
        public ArtistService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;

        }
        public async Task<Artist> CreateArtist(Artist newArtist)
        {
            await _unitOfWork.Artist.AddAsync(newArtist);
            return newArtist;
        }

        public async Task DeleteArtist(Artist artist)
        {
            _unitOfWork.Artist.RemoveAsync(artist);
           await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Artist>> GetAllArtists()
        {
            return await _unitOfWork.Artist.GetAllAsync();
        }

        public async Task<Artist> GetArtistById(int id)
        {
            return await _unitOfWork.Artist.GetByIdAsync(id);
        }

        public async Task UpdateArtist(Artist artistToBeUpdated, Artist artist)
        {
            artistToBeUpdated.Name = artist.Name;
            artistToBeUpdated.Musics = artist.Musics;

            await _unitOfWork.CommitAsync();
        }
    }
}