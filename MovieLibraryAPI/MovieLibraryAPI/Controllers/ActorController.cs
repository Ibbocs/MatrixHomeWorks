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
    public class ActorController : ControllerBase
    {
        private IActorService actorService;
        public ActorController(IActorService _actorService)
        {
            actorService= _actorService;
        }

        [HttpGet]
        public async Task<List<Actor>> GetAllActor()
        {
            return await actorService.GetAllActor();
        }

        [HttpGet("{id}")]
        public async Task<List<Actor>> GetAllActor(int id)
        {
            return await actorService.GetAllActor(id);
        }

        [HttpPost]
        public async Task<AddActorDTO> AddActor([FromQuery]AddActorDTO addActorDTO)
        {
            return await actorService.AddActor(addActorDTO);
        }

        [HttpPut]
        public async Task<AddActorDTO> UpdateActor([FromQuery]AddActorDTO addActorDTO, int id)
        {
            return await actorService.UpdateActor(addActorDTO, id);
        }

        [HttpDelete]
        public async Task<Actor> DeleteActor(int id)
        {
            return await actorService.DeleteActor(id);
        }
       
    }
}
