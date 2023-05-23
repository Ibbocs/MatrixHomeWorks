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
    public class CourseController : ControllerBase
    {
        private ICourseServices courseServices;
        public CourseController(ICourseServices _courseServices)
        {
            courseServices = _courseServices;
        }

        [HttpGet]
        public async Task<List<Course>> GetAllCourse()
        {
            return await courseServices.GetAllCourse();
        }

        [HttpGet("{id}")]
        public async Task<List<Course>> GetAllCourseId(int id)
        {
            return await courseServices.GetAllCourseId(id);
        }

        [HttpPost]
        public async Task<AddCourseDTO> AddCourse([FromQuery] AddCourseDTO addCourseDTO)
        {
            return await courseServices.AddCourse(addCourseDTO);
        }

        [HttpPut]
        public async Task<AddCourseDTO> UpdateCourse([FromQuery] AddCourseDTO addCourseDTO, [FromQuery] int id)
        {
            return await courseServices.UpdateCourse(addCourseDTO, id);
        }

        [HttpDelete]
        public async Task<Course> DeleteCourse([FromQuery] int id)
        {
            return await courseServices.DeleteCourse(id);
        }
    }
}
