using AutoMapper;
using MovieLibraryAPI.DAL.Entity;
using MovieLibraryAPI.DTO.MovieDB;

namespace MovieLibraryAPI.Business.AutoMap
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<AddMovieDTO, Movie>();
            CreateMap<AddActorDTO, Actor>();
        }
    }
}
