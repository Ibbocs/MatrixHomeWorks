using AutoMapper;
using StudentMVC.Models.DTO;
using StudentMVC.Models.Entity;

namespace StudentMVC.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<List<Student>, Student>();
        }
    }
}
