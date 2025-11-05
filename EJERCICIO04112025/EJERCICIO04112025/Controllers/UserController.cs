using EJERCICIO04112025.models.DTOs;
using EJERCICIO04112025.Services;
using Microsoft.AspNetCore.Mvc;

namespace EJERCICIO04112025.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("registrar")]
        public async Task<IActionResult> Register(RegisterUserDto dbo)
        {
            throw new NotImplementedException();
            try
            {
                var user = await _userService.RegisterUserAsync(dbo);
                return Ok(new {message="Usuario creado ",user.Id, user.UserName});

            }
            catch (Exception ex) {
                return BadRequest(new { error = ex.Message });
        }
    }
}
