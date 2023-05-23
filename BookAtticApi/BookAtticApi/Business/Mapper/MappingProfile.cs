using AutoMapper;
using BookAtticApi.Domain.DTO;
using BookAtticApi.Domain.Entity;

namespace BookAtticApi.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, SellectBookDTO>();
            CreateMap<Author, SellectAuthorDTO>();
            CreateMap<Publisher, SellectPublisherDTO>();
            //CreateMap<SellectAllBPAInfoDTO, >();
        }
    }
}
