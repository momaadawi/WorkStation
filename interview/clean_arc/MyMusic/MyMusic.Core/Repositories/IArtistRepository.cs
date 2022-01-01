using System.Collections.Generic;
using System.Threading.Tasks;
using MyMusic.Core.Models;
namespace MyMusic.Core.Repositories
{
    public interface IArtistRepository : IRepositories<Artist>
    {
        Task<IEnumerable<Artist>> GetAllMusicAsync();
        Task<Artist> GetWithMusicsByIdAsync(int id);
    }
}


