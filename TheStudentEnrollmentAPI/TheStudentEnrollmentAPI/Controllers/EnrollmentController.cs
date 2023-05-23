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
    public class EnrollmentController : ControllerBase
    {
        private IEnrollmentServices enrollmentServices;
        public EnrollmentController(IEnrollmentServices _enrollmentServices)
        {
            enrollmentServices= _enrollmentServices;
        }

        [HttpGet]
        public async Task<List<Enrollment>> GetAllEnrollment()
        {
            return await enrollmentServices.GetAllEnrollment();
        }

        [HttpGet("{id}")]
        public async Task<List<Enrollment>> GetAllEnrollmentId(int id)
        {
            return await enrollmentServices.GetAllEnrollmentId(id);
        }

        [HttpPost]
        public async Task<AddEnrollmentDTO> AddEnrollment([FromQuery] AddEnrollmentDTO addEnrollmentDTO)
        {
            return await enrollmentServices.AddEnrollment(addEnrollmentDTO);
        }

        [HttpPut]
        public async Task<AddEnrollmentDTO> UpdateEnrollment([FromQuery] AddEnrollmentDTO addEnrollmentDTO, [FromQuery] int id)
        {
            return await enrollmentServices.UpdateEnrollment(addEnrollmentDTO, id);
        }

        [HttpDelete]
        public async Task<Enrollment> DeleteEnrollment([FromQuery] int id)
        {
            return await enrollmentServices.DeleteEnrollment(id);
        }
    }
}
