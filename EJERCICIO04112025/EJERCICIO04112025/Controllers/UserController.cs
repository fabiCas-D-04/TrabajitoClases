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
        [HttpGet("obtener")]
        public async Task<IActionResult> Obtener()
        {
            try
            {
                var user = await _userService.GetAllUserAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("registrar")]
        public async Task<IActionResult> Register(RegisterUserDto dbo)
        {
            throw new NotImplementedException();
            try
            {
                var user = await _userService.RegisterUserAsync(dbo);
                return Ok(new { message = "Usuario creado ", user.Id, user.UserName });

            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPut("update")]
        public async Task<IActionResult> Update(RegisterUserDto dbo)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(RegisterUserDto dbo)
        {
            throw new NotImplementedException();
        }
    }
}
