using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MovieCAApi.Application.Service;
using MovieCAApi.Domain.DTOs;
using MovieCAApi.Domain.Entity;
using MovieCAApi.Domain.UnitOfWork;
using MovieCAApi.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCAApi.Percistance.Application.Service
{
    public class MovieService : IMovieService
    {
        private MovieDbContext movieDbContext;
        private IMapper mapper;
        private IUnitOfWork<Movie> unitOfWork;
        public MovieService(MovieDbContext _movieDbContext, IMapper _mapper, IUnitOfWork<Movie> _unitOfWork)
        {
            movieDbContext = _movieDbContext;
            mapper = _mapper;
            unitOfWork = _unitOfWork;
        }

        public async Task<AddMovieDTO> AddMovie(AddMovieDTO addMovieDTO)
        {


            var data = mapper.Map<Movie>(addMovieDTO);
            unitOfWork.repository.Add(data);
            await unitOfWork.SaveChangesAsync();
            //await movieDbContext.Movies.AddAsync(data);
            //await movieDbContext.SaveChangesAsync();
            return addMovieDTO;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie Movie = await movieDbContext.Movies.FirstOrDefaultAsync(c => c.MovieID == id);
            unitOfWork.repository.Delete(Movie);
            await unitOfWork.SaveChangesAsync();
            //movieDbContext.Movies.Remove(Movie);
            //await movieDbContext.SaveChangesAsync();

            return Movie;
        }

        public async Task<List<Movie>> GetAllMovie()
        {
            List<Movie> Movie = (List<Movie>)await unitOfWork.repository.GetAll();
            //var Movie = await movieDbContext.Movies.ToListAsync();

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
            Movie.MovieID = id;

            unitOfWork.repository.Update(Movie);
            await unitOfWork.SaveChangesAsync();
            //movieDbContext.Movies.Update(Movie);
            //await movieDbContext.SaveChangesAsync();

            return addMovieDTO;
        }

        public async Task<Actor> GetActorList(int movieId)
        {
            var data = await movieDbContext.Actors.Include(a => a.MovieActor.Where(m => m.MovieId == movieId)).FirstOrDefaultAsync();

            return data;
        }
    }
}
