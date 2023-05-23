using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheStudentEnrollmentAPI.DAL.Context;
using TheStudentEnrollmentAPI.DAL.Entity;
using TheStudentEnrollmentAPI.DAL.Services.CourseDB.IService;
using TheStudentEnrollmentAPI.DTO.CourseDB;
using TheStudentEnrollmentAPI.Model.CourseDB;

namespace TheStudentEnrollmentAPI.DAL.Services.CourseDB
{
    public class StudentService : IStudentServices
    {
        private CourseDbContext courseDbContext;
        private IMapper mapper;
        public StudentService(CourseDbContext _courseDbContext, IMapper _mapper)
        {
            courseDbContext= _courseDbContext;
            mapper= _mapper;
        }

        public async Task<List<Student>> GetAllStudent()
        {
            //var students = await (from student in courseDbContext.Students
            //                      select student).ToListAsync();

            //bunu model map elmeliyem, sora da modeli vermeliyem?
            var students = await courseDbContext.Students.ToListAsync();

            return students;
        }

        public async Task<List<Student>> GetAllStudentId(int id)
        {
            //bu coursedeservisde islemedi, xeta verir compiletime de
            
            var studentById = await (from student in courseDbContext.Students
                       where student.StudentId == id
                       select student).ToListAsync();
           
            //var students = await courseDbContext.Students.Where(s=> s.StudentId== id).ToListAsync();

            return studentById;
        }

        public async Task<AddStudentDTO> AddStudent(AddStudentDTO addStudentDTO)
        {
            var data = mapper.Map<Student>(addStudentDTO);
            await courseDbContext.Students.AddAsync(data);
            await courseDbContext.SaveChangesAsync();
            return addStudentDTO;
        }

        public async Task<AddStudentDTO> UpdateStudent(AddStudentDTO addStudentDTO, int id)
        {
            #region Niye Olmur Burda Update
            //changeTrackeri ise dusur de, + student ustunde aotomapper ile deyisilik edirem
            //var student = await courseDbContext.Students.FirstOrDefaultAsync(s=> s.StudentId == id);
            //student = mapper.Map<Student>(addStudentDTO);
            //student.StudentId = id;
            //await courseDbContext.Students.AddAsync(student);
            //await courseDbContext.SaveChangesAsync();
            //return addStudentDTO;
            #endregion


            var student = mapper.Map<Student>(addStudentDTO);
            student.StudentId = id;

            courseDbContext.Students.Update(student);
            await courseDbContext.SaveChangesAsync();

            return addStudentDTO;
        }

        public async Task<Student> DeleteStudent(int id)
        {
            //var student = await courseDbContext.Students.Where(s => s.StudentId== id).FirstOrDefaultAsync();
            Student student = await courseDbContext.Students.FirstOrDefaultAsync(s=> s.StudentId == id);
            courseDbContext.Students.Remove(student); 
            await courseDbContext.SaveChangesAsync();

            return student;
        }
    }
}
