using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentMVC.Configirations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Name = "Operator",
                   NormalizedName = "Oper"
               },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "Admin"
                }


                );
        }

    }
}
