using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthoAndLogger.Configuration
{
    public class UserRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Name = "User",
                   NormalizedName = "user"
               },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "admin"
                }
                );
        }
    }
}
