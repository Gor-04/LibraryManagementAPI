using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
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

        [HttpGet("List")]
        public IActionResult GetAllUsers()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("GetUserById")]
        public IActionResult GetUserById(int userId)
        {
            return Ok(_userService.GetUserById(userId));
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(UserEntity user)
        {
            _userService.AddUser(user);
            return Ok();
        }

        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int userId)
        {
            _userService.DeleteUser(userId);
            return Ok();
        }
    }
}
