using JWTTokenAuthAspNet6_BLL.Contract;
using JWTTokenAuthAspNet6_BLL.Model;
using Microsoft.AspNetCore.Mvc;

namespace JWTTokenAuthAspNet6_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync (RegisterModelDTO model)
        {
            var result = await _userService.RegisterAsync (model);
            return Ok(result);
        }


    }
}
