using JwtRollBaseAuthAndLogger.Model.Model;

namespace JwtRollBaseAuthAndLogger.Services.Abstract
{
    public interface IUserService
    {
        public Task<UserModel> GetUserById(string name);
    }   
}
