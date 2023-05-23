using AutoMapper;
using MovieCAApi.Domain.DTOs;
using MovieCAApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCAApi.Percistance.Application.AutoMap
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddMovieDTO, Movie>();
            CreateMap<AddActorDTO, Actor>();
        }
    }
}
