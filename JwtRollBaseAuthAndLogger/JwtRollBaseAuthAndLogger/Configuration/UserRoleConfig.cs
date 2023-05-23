using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JwtRollBaseAuthAndLogger.Configuration
{
    public class UserRoleConfig :IEntityTypeConfiguration<IdentityRole>
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
