using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Models.DTO;
using StudentMVC.Models.Entity;
using StudentMVC.Service.Abstract;
using System.Linq;

namespace StudentMVC.Service.Impliment
{
    public class StudentService : IStudentService
    {
        private StudentMVCContext studentMVCContext;
        private IMapper mapper;

        public StudentService(StudentMVCContext _studentMVCContext, IMapper _mapper)
        {
            studentMVCContext = _studentMVCContext;
            mapper = _mapper; 
        }

        public async Task<Student> AddStudent(StudentDTO addStudentDTO)
        {
            var data = mapper.Map<Student>(addStudentDTO);
            await studentMVCContext.Student.AddAsync(data);
            await studentMVCContext.SaveChangesAsync();

            var lastData = studentMVCContext.Student.OrderBy(x=> x.Id).LastOrDefault();
            return lastData;
        }

        public async Task<Student> DeleteStudent(int? id)
        {
            try
            {
                Student student = await studentMVCContext.Student.FirstOrDefaultAsync(s => s.Id == id);
                studentMVCContext.Student.Remove(student);
                await studentMVCContext.SaveChangesAsync();

                return student;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return null;
            
        }

        public async Task<List<Student>> GetAllStudent()
        {
            try
            {
                var getData = await studentMVCContext.Student.ToListAsync();
                //var data = mapper.Map<Student>(getData);
                //return data;
                return getData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
           
        }

        public async Task<List<Student>> GetStudentById(int id)
        {
            try
            {
                var data = await studentMVCContext.Student.Where(s => s.Id == id).ToListAsync();
                return data;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public async Task<Student> UpdateStudent(Student Student, int id)
        {
            try
            {
                var data = mapper.Map<Student>(Student);
                studentMVCContext.Student.Update(data);
                await studentMVCContext.SaveChangesAsync();

                return await studentMVCContext.Student.FirstOrDefaultAsync(s => s.Id == id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
           
        }
    }
}
