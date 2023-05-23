using System.ComponentModel.DataAnnotations;

namespace TheStudentEnrollmentAPI.DAL.Entity
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int Grade { get; set; }
        
       
    }

}
