using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryAPI.Business.IServices;
using MovieLibraryAPI.DAL.Entity;
using MovieLibraryAPI.DTO.MovieDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService movieService;
        public MovieController(IMovieService _movieService)
        {
            movieService = _movieService;
        }

        [HttpGet]
        public Task<List<Movie>> GetAllMovie()
        {
            return movieService.GetAllMovie();
        }

        [HttpGet("{id}")]
        public Task<List<Movie>> GetAllMovie(int id)
        {
            return movieService.GetAllMovie(id);
        }
        [HttpPost]
        public Task<AddMovieDTO> AddMovie([FromQuery]AddMovieDTO addMovieDTO)
        {
            return movieService.AddMovie(addMovieDTO);
        }

        [HttpPut]
        public Task<AddMovieDTO> UpdateMovie([FromQuery]AddMovieDTO addMovieDTO, int id)
        {
            return movieService.UpdateMovie(addMovieDTO, id);
        }

        [HttpDelete]
        public Task<Movie> DeleteMovie(int id)
        {
            return movieService.DeleteMovie(id);
        }

        [HttpGet("{movieId}")]
        public async Task<Actor> GetActorList(int movieId)
        {
            return await movieService.GetActorList(movieId);
        }
    }
}
