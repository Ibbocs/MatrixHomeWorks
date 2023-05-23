using Microsoft.EntityFrameworkCore;
using System.Data;
using TheStudentEnrollmentAPI.DAL.Entity;

namespace TheStudentEnrollmentAPI.DAL.Context
{
    public class CourseDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Enrollment>().HasKey(e => new {e.StudentId, e.CourseId, e.EnrollmentId});

            modelBuilder.Entity<Enrollment>()
                .HasOne<Student>(s => s.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(s => s.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Enrollment>()
                .HasOne<Course>(s => s.Course)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(s => s.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

        }

    }
}
