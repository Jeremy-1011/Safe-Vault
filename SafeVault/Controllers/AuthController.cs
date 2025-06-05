
using Microsoft.AspNetCore.Mvc;
using SafeVault.Models;
using Microsoft.AspNetCore.Authorization;

namespace SafeVault.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Secure login logic
                // Copilot helped generate token auth logic here
                if (model.Username == "admin" && model.Password == "securePassword123")
                {
                    return Ok(new { Token = "mock-jwt-token", Role = "Admin" });
                }
                return Unauthorized();
            }
            return BadRequest(ModelState);
        }
    }
}
