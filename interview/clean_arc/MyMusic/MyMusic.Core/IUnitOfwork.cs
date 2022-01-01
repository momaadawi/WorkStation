using System;
using System.Threading.Tasks;
using MyMusic.Core.Repositories;

namespace MyMusic.Core
{
    public interface IUnitOfWork : IDisposable
    {   
        IMusicRepository Music {get;}
        IArtistRepository Artist {get;}
        Task<int> CommitAsync();
    }
}