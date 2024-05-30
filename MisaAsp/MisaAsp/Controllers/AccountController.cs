using Microsoft.AspNetCore.Mvc;
using MisaAsp.Models;
using MisaAsp.Services;
using System.Threading.Tasks;

namespace MisaAsp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;

        public AccountController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var token = await _registrationService.AuthenticateUserAsync(request);

            if (!string.IsNullOrEmpty(token))
            {
                return Ok(new { Token = token });
            }
            else
            {
                return Unauthorized(new { Message = "Invalid credentials" });
            }
        }

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _registrationService.GetAllUsersAsync();

            if (users != null)
            {
                return Ok(users);
            }
            else
            {
                return StatusCode(500, "An error occurred while retrieving users.");
            }
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = await _registrationService.RegisterUserAsync(request);

            if (userId > 0)
            {
                return Ok(new { Message = "Registration successful!", UserId = userId });
            }
            else
            {
                return StatusCode(500, "An error occurred while registering the user.");
            }
        }
    }
}
