using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;

namespace MyMusic.Data.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        private readonly MyMusicDbContext _context;
        public ArtistRepository(MyMusicDbContext context) : base(context)
        {
            this._context = context;           
        }

        public Task<IEnumerable<Artist>> GetAllMusicAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Artist> GetWithMusicsByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}