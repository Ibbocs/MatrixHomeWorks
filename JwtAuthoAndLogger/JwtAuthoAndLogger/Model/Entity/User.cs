using Microsoft.AspNetCore.Identity;

namespace JwtAuthoAndLogger.Model.Entity
{
    public class User: IdentityUser
    {
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
    }
}
