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
    public class ActorService: IActorService
    {
        private MovieDbContext movieDbContext;
        private IMapper mapper;
        public ActorService(MovieDbContext _movieDbContext, IMapper _mapper)
        {
            movieDbContext = _movieDbContext;
            mapper = _mapper;
        }

        public async Task<AddActorDTO> AddActor(AddActorDTO addActorDTO)
        {
            var data = mapper.Map<Actor>(addActorDTO);
            await movieDbContext.Actors.AddAsync(data);
            await movieDbContext.SaveChangesAsync();
            return addActorDTO;
        }

        public async Task<Actor> DeleteActor(int id)
        {
            Actor Actor = await movieDbContext.Actors.FirstOrDefaultAsync(c => c.ActorID == id);
            movieDbContext.Actors.Remove(Actor);
            await movieDbContext.SaveChangesAsync();

            return Actor;
        }

        public async Task<List<Actor>> GetAllActor()
        {
            var Actor = await movieDbContext.Actors.ToListAsync();

            return Actor;
        }

        public async Task<List<Actor>> GetAllActor(int id)
        {
            var ActorById = await movieDbContext.Actors.Where(m => m.ActorID == id).ToListAsync();

            return ActorById;
        }

        public async Task<AddActorDTO> UpdateActor(AddActorDTO addActorDTO, int id)
        {
            var Actor = mapper.Map<Actor>(addActorDTO);
            Actor.ActorID = id;

            movieDbContext.Actors.Update(Actor);
            await movieDbContext.SaveChangesAsync();

            return addActorDTO;
        }
    }
}
