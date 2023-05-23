using AutoMapper;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<AddStudentDTO, Student>();
            CreateMap<AddCourseDTO, Course>();
            CreateMap<AddEnrollmentDTO, Enrollment>();
        }
    }
}
