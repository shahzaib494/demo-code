using KoperasiTentera.Contracts.User;
using KoperasiTentera.User.Abstraction.User;
using Microsoft.AspNetCore.Mvc;

namespace KoperasiTentera.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecast2Controller : ControllerBase
    {
        private readonly IUserService _userService;

        public WeatherForecast2Controller(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }
    }
}
