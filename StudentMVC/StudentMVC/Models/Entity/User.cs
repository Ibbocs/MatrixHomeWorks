using Microsoft.AspNetCore.Identity;

namespace StudentMVC.Models.Entity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
    }
}
