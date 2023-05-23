using MovieLibraryAPI.DAL.Entity;
using MovieLibraryAPI.DTO.MovieDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Business.IServices
{
    public interface IActorService
    {
        public Task<List<Actor>> GetAllActor();
        public Task<List<Actor>> GetAllActor(int id);
        public Task<AddActorDTO> AddActor(AddActorDTO addActorDTO);
        public Task<AddActorDTO> UpdateActor(AddActorDTO addActorDTO, int id);
        public Task<Actor> DeleteActor(int id);
    }
}
