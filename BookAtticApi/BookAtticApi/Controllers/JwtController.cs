using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BookAtticApi.Controllers
{
    public class JwtController : Controller
    {
        private readonly IConfiguration _configuration;

        public JwtController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("login")]
        public async Task<string> login(string name, string surname, string email)
        {
            var tokerhandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]);

            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Surname, surname),
                new Claim(ClaimTypes.Email, email),
                }),

                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature)

            };

            var token = tokerhandler.CreateToken(tokenDescription);

            return tokerhandler.WriteToken(token);
        }
    }
}
