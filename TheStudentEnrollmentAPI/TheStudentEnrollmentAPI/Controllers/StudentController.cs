using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentServices studentServices;
        public StudentController(IStudentServices _studentServices)
        {
            studentServices = _studentServices;
        }

        [HttpGet]
        public async Task<List<Student>> GetAllStudent()
        {
            return await studentServices.GetAllStudent();
        }

        [HttpGet("{id}")]
        public async Task<List<Student>> GetAllStudentId(int id)
        {
            return await studentServices.GetAllStudentId(id);
        }

        [HttpPost]
        public async Task<AddStudentDTO> AddStudent([FromQuery]AddStudentDTO addStudentDTO)
        {
            return await studentServices.AddStudent(addStudentDTO);

        }

        [HttpPut]
        public async Task<AddStudentDTO> UpdateStudent([FromQuery] AddStudentDTO addStudentDTO, [FromQuery]int id)
        {
            return await studentServices.UpdateStudent(addStudentDTO, id);

        }

        [HttpDelete]
        public async Task<Student> DeleteStudent([FromQuery]int id)
        {
            return  await studentServices.DeleteStudent(id);
        }
    }
}
