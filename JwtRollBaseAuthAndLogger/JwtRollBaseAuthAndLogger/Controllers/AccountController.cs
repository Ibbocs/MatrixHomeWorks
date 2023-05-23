using JwtRollBaseAuthAndLogger.Context;
using JwtRollBaseAuthAndLogger.Model.DTO;
using JwtRollBaseAuthAndLogger.Model.Entity;
using JwtRollBaseAuthAndLogger.Services.Abstract;
using JwtRollBaseAuthAndLogger.Services.Implement;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JwtRollBaseAuthAndLogger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService userService;

        public AccountController( IUserService _userService)
        {
            this.userService = userService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {
            var user = await userService.GetUserById(request.Username);
            if (user.Username != request.Username)
            {
                return BadRequest("User not found.");
            }

            {
                List<Claim> claims = new List<Claim>
                {
                       new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.)
                };
            }
            
             

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                    _configuration.GetSection("AppSettings:Token").Value));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

                var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: creds);

                var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            

            var refreshToken = GenerateRefreshToken();
            SetRefreshToken(refreshToken);

            return Ok(token);
        }
    }

    
    
}
