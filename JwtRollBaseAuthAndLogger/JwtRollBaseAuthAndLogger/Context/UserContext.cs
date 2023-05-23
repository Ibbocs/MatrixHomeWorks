using JwtRollBaseAuthAndLogger.Configuration;
using JwtRollBaseAuthAndLogger.Model.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace JwtRollBaseAuthAndLogger.Context
{
    public class UserContext :IdentityDbContext
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
