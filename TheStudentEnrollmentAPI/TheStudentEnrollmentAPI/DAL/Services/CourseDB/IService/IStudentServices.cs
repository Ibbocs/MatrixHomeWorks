using System.Collections.Generic;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService
{
    public interface IStudentServices
    {
        public Task<List<Student>> GetAllStudent();
        public Task<List<Student>> GetAllStudentId(int id);
        public Task<AddStudentDTO> AddStudent(AddStudentDTO addStudentDTO);
        public Task<AddStudentDTO> UpdateStudent(AddStudentDTO addStudentDTO, int id);
        public Task<Student> DeleteStudent(int id);

    }
}
