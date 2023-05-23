using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieLibraryAPI.Business.IServices;
using MovieLibraryAPI.DAL.Context;
using MovieLibraryAPI.DAL.Entity;
using MovieLibraryAPI.DTO.MovieDB;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Business.Services
{
    public class MovieService : IMovieService
    {
        private MovieDbContext movieDbContext;
        private IMapper mapper;
        public MovieService(MovieDbContext _movieDbContext, IMapper _mapper)
        {
            movieDbContext= _movieDbContext;
            mapper= _mapper;
        }

        public async Task<AddMovieDTO> AddMovie(AddMovieDTO addMovieDTO)
        {
            
            var data = mapper.Map<Movie>(addMovieDTO);
            await movieDbContext.Movies.AddAsync(data);
            await movieDbContext.SaveChangesAsync();
            return addMovieDTO;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie Movie = await movieDbContext.Movies.FirstOrDefaultAsync(c => c.MovieID == id);
            movieDbContext.Movies.Remove(Movie);
            await movieDbContext.SaveChangesAsync();

            return Movie;
        }

        public async Task<List<Movie>> GetAllMovie()
        {
            var Movie = await movieDbContext.Movies.ToListAsync();

            return Movie;
        }

        public async Task<List<Movie>> GetAllMovie(int id)
        {
            var MovieById = await movieDbContext.Movies.Where(m => m.MovieID == id).ToListAsync();

            return MovieById;
        }

        public async Task<AddMovieDTO> UpdateMovie(AddMovieDTO addMovieDTO, int id)
        {
            var Movie = mapper.Map<Movie>(addMovieDTO);
            Movie.MovieID= id;

            movieDbContext.Movies.Update(Movie);
            await movieDbContext.SaveChangesAsync();

            return addMovieDTO;
        }

        public async Task<Actor> GetActorList(int movieId)
        {
            var data = await movieDbContext.Actors.Include(a=> a.MovieActor.Where(m=> m.MovieId==movieId)).FirstOrDefaultAsync();
           
            return data;
        }
    }
}

