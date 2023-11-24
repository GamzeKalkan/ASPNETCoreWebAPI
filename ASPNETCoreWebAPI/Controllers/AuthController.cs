using ASPNETCoreWebAPI.Models;
using ASPNETCoreWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] Users user)
        {

            if (_authService.ValidateCredentials(user))
            {


                var token = _authService.GenerateJwtToken(user);


                return Ok(new { Token = token });
            }


            return Unauthorized("Kullanıcı adı veya şifre hatalı.");
        }
        [HttpGet("token")]
        public IActionResult GetToken([FromQuery] Users user)
        {

            if (_authService.ValidateCredentials(user))
            {

                var token = _authService.GenerateJwtToken(user);

                return Ok(new { Token = token });
            }


            return Unauthorized("Kullanıcı adı veya şifre hatalı.");
        }
    }
}
