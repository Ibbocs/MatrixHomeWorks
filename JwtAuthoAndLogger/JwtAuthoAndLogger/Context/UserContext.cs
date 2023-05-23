using JwtAuthoAndLogger.Configuration;
using JwtAuthoAndLogger.Model.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthoAndLogger.Context
{
    public class UserContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
          : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserRoleConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
