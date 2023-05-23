using MovieCAApi.Domain.DTOs;
using MovieCAApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCAApi.Application.Service
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
