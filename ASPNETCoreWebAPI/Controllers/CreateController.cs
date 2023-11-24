using ASPNETCoreWebAPI.Models;
using ASPNETCoreWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreateController : ControllerBase
    {
        private readonly AddService _Service;

        public CreateController(AddService Service)
        {
            _Service = Service;
        }

        [HttpPost("add-users")]
        public IActionResult AddUser([FromBody] Users users)
        {
            _Service.AddUser(users);
            return Ok("User added successfully.");
        }

        [HttpPost("add-address")]
        public IActionResult AddAddress([FromBody] Addresses address)
        {
            _Service.AddAddress(address);
            return Ok("Address added successfully.");
        }
    }
}
