using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCAApi.Application.Service;
using MovieCAApi.Domain.Entity;
using System.Threading.Tasks;

namespace MovieCleanArchitectureApi.Controllers
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
