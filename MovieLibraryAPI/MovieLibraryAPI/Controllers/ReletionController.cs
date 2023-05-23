using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryAPI.Business.IServices;
using MovieLibraryAPI.DAL.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReletionController : ControllerBase
    {
        private IMovieService movieService;
        public ReletionController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [HttpGet("{movieId}")]
        public async Task<Actor> GetActorList(int movieId)
        {
            return await movieService.GetActorList(movieId);
        }
    }
}
