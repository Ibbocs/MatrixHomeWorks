using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Models.Entity;

    public class StudentMVCContext : DbContext
    {
        public StudentMVCContext (DbContextOptions<StudentMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMVC.Models.Entity.Student> Student { get; set; } = default!;
        public DbSet<StudentMVC.Models.Entity.User> Users { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
