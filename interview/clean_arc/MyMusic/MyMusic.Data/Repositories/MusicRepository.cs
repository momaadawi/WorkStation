using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;

namespace MyMusic.Data.Repositories
{
    public class MusicRepository : Repository<Music> , IMusicRepository
    {
        private readonly MyMusicDbContext _context;
        public MusicRepository(MyMusicDbContext context) : base(context)
        {
            this._context = context;           
        }

        public async Task<IEnumerable<Music>> GetAllWithArtists()
        {
            return await _context.Musics
                .Include( m => m.Artist)
                .ToArrayAsync();
        }

        public async Task<Music> GetWithArtistById(int id)
        {
            return await _context.Musics
                .Include( m => m.Artist)
                .SingleOrDefaultAsync( m => m.Artist.Id == id);
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistId(int artistId)
        {
            return await _context.Musics
                .Where( m => m.ArtistId == artistId)
                .Include( m => m.Artist)
                .ToListAsync();
        }

        public Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Music> GetWithArtistByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Music>> GetAllWithArtistByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}