using System.Collections.Generic;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService
{
    public interface IEnrollmentServices
    {
        public Task<List<Enrollment>> GetAllEnrollment();
        public Task<List<Enrollment>> GetAllEnrollmentId(int id);
        public Task<AddEnrollmentDTO> AddEnrollment(AddEnrollmentDTO addEnrollmentDTO);
        public Task<AddEnrollmentDTO> UpdateEnrollment(AddEnrollmentDTO addEnrollmentDTO, int id);
        public Task<Enrollment> DeleteEnrollment(int id);
    }
}
