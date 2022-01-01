using System.Collections.Generic;
using System.Threading.Tasks;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;
namespace MyMusic.Core.Repositories
{
    public interface IMusicRepository : IRepositories<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<Music> GetWithArtistByIdAsync(int id);
        Task<IEnumerable<Music>> GetAllWithArtistByIdAsync(int id);
    }
}


