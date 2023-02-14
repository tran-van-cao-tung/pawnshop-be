using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PawnShopBE.Core.Models;
using Services;

namespace PawnShopBE.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            var isUser = await _userService.CreateUser(user);

            if (isUser)
            {
                return Ok(isUser);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IActionResult> getUserList()
        {
            var userList = await _userService.GetAllUsers();
            if (userList == null)
            {
                return NotFound();
            }
            return Ok(userList);
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            var user = await _userService.GetUserById(userId);

            if (user != null)
            {
                return Ok(User);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (user != null)
            {
                var isUserCreated = await _userService.UpdateUser(user);
                if (isUserCreated)
                {
                    return Ok(isUserCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid userId)
        {
            var isUserCreated = await _userService.DeleteUser(userId);

            if (isUserCreated)
            {
                return Ok(isUserCreated);
            }
            else
            {
                return BadRequest();
            }
        }
    
}
}
