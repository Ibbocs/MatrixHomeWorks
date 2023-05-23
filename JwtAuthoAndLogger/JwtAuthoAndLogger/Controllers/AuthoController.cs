using JwtAuthoAndLogger.Context;
using JwtAuthoAndLogger.Model.DTO;
using JwtAuthoAndLogger.Model.Entity;
using JwtAuthoAndLogger.Model.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace JwtAuthoAndLogger.Controllers
{
    //"userId": "0cc5a20f-17ac-42ff-9ac3-7446daea9778",
    //"username": "admin",
    //"email": "string@gmail.com",
    //"password": "string",
    //"role": "Admin"
    [Route("api/[controller]")]
    [ApiController]
    public class AuthoController : ControllerBase
    {
        private readonly UserContext userContext;
        private readonly IConfiguration configuration;
        private readonly ILogger<AuthoController> logger;

        public AuthoController(UserContext _userContext, IConfiguration _configuration, ILogger<AuthoController> logger)
        {
            this.userContext = _userContext;
            this.configuration = _configuration;
            this.logger = logger;
        }

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDTO request)
        {
            User user = new();

            try
            {
                user.UserName = request.Username;
                user.Email = request.Email;
                user.PasswordHash = request.Password;
                user.Role = request.Role;

                logger.LogInformation($"User Email: {request.Email}");

                await userContext.Users.AddAsync(user);
                await userContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

               logger.LogError(ex.Message, ex.ToString());
            }
           


            return Ok(user);
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserModel request)
        {

            try
            {
                var data = await userContext.Users.FirstOrDefaultAsync(x => x.Id == request.UserId);

                if (data.UserName != request.Username)
                {
                    logger.LogWarning("User not found.");
                    return BadRequest("User not found.");
                }

                if (data.PasswordHash != request.Password)
                {
                    logger.LogWarning("Wrong password.");
                    return BadRequest("Wrong password.");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex.ToString());
                return BadRequest("Wrong");
            }




            //List<Claim> claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, request.Username),
            //    new Claim(ClaimTypes.Role, request.Role),
            //    new Claim(ClaimTypes.Email, request.Email),
            //};

            //var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            //    configuration.GetSection("Jwt:Key").Value));

            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            //var token = new JwtSecurityToken(
            //    claims: claims,
            //    expires: DateTime.Now.AddDays(1),
            //    signingCredentials: creds);

            //var jwt = new JwtSecurityTokenHandler().WriteToken(token);


            //
            try
            {
                var tokerhandler = new JwtSecurityTokenHandler();
                var tokenkey = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);

                var tokenDescription = new SecurityTokenDescriptor
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                    {
                new Claim(ClaimTypes.Name, request.Username),
                new Claim(ClaimTypes.Role, request.Role),
                new Claim(ClaimTypes.Email, request.Email)
                        //new Claim(ClaimTypes.Password, request.Password)
                    }),

                    Expires = DateTime.UtcNow.AddMinutes(10),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature)

                };

                var token = tokerhandler.CreateToken(tokenDescription);
                var writtenToken = tokerhandler.WriteToken(token);

                return Ok(writtenToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message, ex.ToString());
                return BadRequest("Wrong");
            }
           
        }

    }
}
