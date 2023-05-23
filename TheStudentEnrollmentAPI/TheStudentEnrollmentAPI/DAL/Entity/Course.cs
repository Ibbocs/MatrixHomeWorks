using System.Collections.Generic;

namespace TheStudentEnrollmentAPI.DAL.Entity
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }

}
