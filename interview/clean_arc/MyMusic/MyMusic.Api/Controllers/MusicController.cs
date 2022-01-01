using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMusic.Core.Models;
using MyMusic.Core.Services;

namespace MyMusic.Api.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class MusicController : ControllerBase
    {
        private readonly IMusicService _musicService;

        public MusicController(IMusicService musicService)
        {
            this._musicService = musicService;
        }
        public async Task<ActionResult<IEnumerable<Music>>> GetAllMusic()
        {
            return Ok(await _musicService.GetAllWithArtist());
        }
    }
}