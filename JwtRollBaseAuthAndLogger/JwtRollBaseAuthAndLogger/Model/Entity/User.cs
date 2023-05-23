using Microsoft.AspNetCore.Identity;

namespace JwtRollBaseAuthAndLogger.Model.Entity
{
    public class User :IdentityUser
    {
        public byte[] PasswordSalt { get; set; }
        //public string Role { get; set; }
    }
}
