using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Context;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService;
using TheStudentEnrollmentAPI.DTO.CourseDB;

namespace TheStudentEnrollmentAPI.DAL.Services.CourseDB
{
    public class CourseService : ICourseServices
    {
        private CourseDbContext courseDbContext;
        private IMapper mapper;
        public CourseService(CourseDbContext _courseDbContext, IMapper _mapper)
        {
            courseDbContext = _courseDbContext;
            mapper = _mapper;
        }

        public async Task<List<Course>> GetAllCourse()
        {
            var course = await courseDbContext.Courses.ToListAsync();

            return course;
        }

        public async Task<List<Course>> GetAllCourseId(int id) 
        {
            //var CourseById = await ( from course in courseDbContext.Courses where course.CourseId == id
            //                        select course ).ToListAsync();


            var CourseById = await courseDbContext.Courses.Where(c=> c.CourseId== id).ToListAsync();

            return CourseById;
        }

        public async Task<AddCourseDTO> AddCourse(AddCourseDTO addCourseDTO)
        {
            var data = mapper.Map<Course>(addCourseDTO);
            await courseDbContext.Courses.AddAsync(data);
            await courseDbContext.SaveChangesAsync();
            return addCourseDTO;
        }

        public async Task<AddCourseDTO> UpdateCourse(AddCourseDTO addCourseDTO, int id)
        {

            var course = mapper.Map<Course>(addCourseDTO);
            course.CourseId = id;

            courseDbContext.Courses.Update(course);
            await courseDbContext.SaveChangesAsync();

            return addCourseDTO;
        }

        public async Task<Course> DeleteCourse(int id)
        {
            Course course = await courseDbContext.Courses.FirstOrDefaultAsync(c => c.CourseId == id);
            courseDbContext.Courses.Remove(course);
            await courseDbContext.SaveChangesAsync();

            return course;
        }
    }
}

