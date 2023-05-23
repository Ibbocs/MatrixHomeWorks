using System.Collections;
using System.Collections.Generic;

namespace TheStudentEnrollmentAPI.DAL.Entity
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }

}
