using AutoMapper;
using EFwithAutoMapperAndLinQ.Domain.DTO;
using EFwithAutoMapperAndLinQ.Domain.Entity;

namespace EFwithAutoMapperAndLinQ.Domain
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CommentDTO, Comment>();
            CreateMap<PostDTO, Post>();
        }
    }
}
