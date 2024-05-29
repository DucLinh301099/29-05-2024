using Microsoft.AspNetCore.Mvc;
using MisaAsp.Models;
using MisaAsp.Services;
using System.Threading.Tasks;

namespace MisaAsp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationService _registrationService;

        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
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

        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole(int userId, string roleName)
        {
            if (await _registrationService.UserHasRoleAsync(userId, roleName))
            {
                return BadRequest(new { Message = "User already has this role." });
            }

            await _registrationService.AssignRoleAsync(userId, roleName);
            return Ok(new { Message = "Role assigned successfully!" });
        }
    }
}
