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
    public class EnrollmentService : IEnrollmentServices
    {
        private CourseDbContext courseDbContext;
        private IMapper mapper;
        public EnrollmentService(CourseDbContext _courseDbContext, IMapper _mapper)
        {
            courseDbContext = _courseDbContext;
            mapper = _mapper;
        }


        public async Task<List<Enrollment>> GetAllEnrollment()
        {
            var Enrollment = await courseDbContext.Enrollments.ToListAsync();

            return Enrollment;
        }

        public async Task<List<Enrollment>> GetAllEnrollmentId(int id)
        {
            var EnrollmentById = await courseDbContext.Enrollments.Where(c => c.EnrollmentId == id).ToListAsync();

            return EnrollmentById;
        }

        public async Task<AddEnrollmentDTO> AddEnrollment(AddEnrollmentDTO addEnrollmentDTO)
        {
            var data = mapper.Map<Enrollment>(addEnrollmentDTO);
            await courseDbContext.Enrollments.AddAsync(data);
            await courseDbContext.SaveChangesAsync();
            return addEnrollmentDTO;
        }

        public async Task<AddEnrollmentDTO> UpdateEnrollment(AddEnrollmentDTO addEnrollmentDTO, int id)
        {
            //burda cedvelde enrollmentId isIdentiti deyil deye xeta olur deyesen
            //ya da cascad yazmaliyam tabloda
            var Enrollment = mapper.Map<Enrollment>(addEnrollmentDTO);
            Enrollment.EnrollmentId = id;

            courseDbContext.Enrollments.Update(Enrollment);
            await courseDbContext.SaveChangesAsync();

            return addEnrollmentDTO;
        }

        public async Task<Enrollment> DeleteEnrollment(int id)
        {
            Enrollment Enrollment = await courseDbContext.Enrollments.FirstOrDefaultAsync(c => c.EnrollmentId == id);
            courseDbContext.Enrollments.Remove(Enrollment);
            await courseDbContext.SaveChangesAsync();

            return Enrollment;
        }
    }
}
