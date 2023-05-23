using StudentMVC.Models.DTO;
using StudentMVC.Models.Entity;

namespace StudentMVC.Service.Abstract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetAllStudent();
        public Task<List<Student>> GetStudentById(int id);
        public Task<Student> AddStudent(StudentDTO addStudentDTO);
        public Task<Student> UpdateStudent(Student Student, int id);
        public Task<Student> DeleteStudent(int? id);
    }
}
