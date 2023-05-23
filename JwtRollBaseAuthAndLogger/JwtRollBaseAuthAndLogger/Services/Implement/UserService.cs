using JwtRollBaseAuthAndLogger.Context;
using JwtRollBaseAuthAndLogger.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace JwtRollBaseAuthAndLogger.Services.Implement
{
    public class UserService
    {
        private readonly UserContext userContext;

        public UserService(UserContext _userContext)
        {
            this.userContext = _userContext;
        }

        public async Task<UserModel> GetUserById(string name)
        {
            UserModel userModel = new UserModel();
            var userbyId = await userContext.Users.Where(x=> x.UserName == name).FirstOrDefaultAsync();
            userModel.Email = userbyId.Email;
            userModel.Username = userbyId.UserName;
            userModel.Password = userbyId.PasswordHash;
            userModel.Role = userbyId.Role;

            return(userModel);

            
        }
    }
}
