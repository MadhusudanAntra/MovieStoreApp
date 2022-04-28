using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServiceAsync accountServiceAsync;
        private readonly IConfiguration configuration;
        public AccountController(IAccountServiceAsync _accountServiceAsync, IConfiguration config)
        {
            accountServiceAsync = _accountServiceAsync;
            configuration = config;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(MovieUserModel user)
        { 
            var result = await accountServiceAsync.SignUpAsync(user);
            if (result.Succeeded)
                return Ok(result.Succeeded);

            return Unauthorized(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginModel login)
        {
            var result = await accountServiceAsync.Login(login);
            if (result.Succeeded)
            {
                // use claims to check the token
                var authenticationClaims = new List<Claim> {
            new Claim(ClaimTypes.Name, login.Username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            };

                var secuirtyKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecurityKey"]));
                var token = new JwtSecurityToken(
                    issuer: configuration["JWT:ValidIssuer"],
                    audience: configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddMinutes(20),
                    claims: authenticationClaims,
                    signingCredentials: new SigningCredentials(secuirtyKey, SecurityAlgorithms.HmacSha256Signature)
                    );
                var tokenWrites = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(tokenWrites);
            }
            return Unauthorized();
        }
    }
}
