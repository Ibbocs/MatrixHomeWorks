using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using MovieCAApi.Application.Service;
using MovieCAApi.Domain.DTOs;
using MovieCAApi.Domain.Entity;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieCleanArchitectureApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private IActorService actorService;


        public ActorController(IActorService _actorService)
        {
            actorService = _actorService;

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

        [HttpPost("new-actor")]
        public async Task<AddActorDTO> AddActor([FromQuery] AddActorDTO addActorDTO)
        {
            return await actorService.AddActor(addActorDTO);
        }

        [HttpPut("change-actor")]
        public async Task<AddActorDTO> UpdateActor([FromQuery] AddActorDTO addActorDTO, int id)
        {
            return await actorService.UpdateActor(addActorDTO, id);
        }

        [HttpDelete("remove-actor")]
        public async Task<Actor> DeleteActor(int id)
        {
            return await actorService.DeleteActor(id);
        }

        //[HttpPost("actorAdd")]
        //public async Task<string> Post(Post root)
        //{
        //    using (HttpClient client = httpClientFactory.CreateClient())
        //    {
        //        string url = "https://localhost:44384/api/Comment/";
        //        string json = JsonConvert.SerializeObject(root);
        //        var data = new StringContent(json, Encoding.UTF8, "application/json");
        //        var response = await client.PostAsync(url, data);
        //    }

        //    return null;
        //}

    }
}
