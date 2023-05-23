using MovieLibraryAPI.DAL.Entity;
using MovieLibraryAPI.DTO.MovieDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Business.IServices
{
    public interface IMovieService
    {
        public Task<List<Movie>> GetAllMovie();
        public Task<List<Movie>> GetAllMovie(int id);
        public Task<AddMovieDTO> AddMovie(AddMovieDTO addMovieDTO);
        public Task<AddMovieDTO> UpdateMovie(AddMovieDTO addMovieDTO, int id);
        public Task<Movie> DeleteMovie(int id);

        public Task<Actor> GetActorList(int movieId);
    }
}
