using System.Collections.Generic;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService
{
    public interface ICourseServices
    {
        public Task<List<Course>> GetAllCourse();
        public Task<List<Course>> GetAllCourseId(int id);
        public Task<AddCourseDTO> AddCourse(AddCourseDTO addCourseDTO);
        public Task<AddCourseDTO> UpdateCourse(AddCourseDTO addCourseDTO, int id);
        public Task<Course> DeleteCourse(int id);
    }
}
