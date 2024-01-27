using FullCart.Application.Contracts;
using Microsoft.AspNetCore.Mvc;
using User = FullCart.Domain.Models.User;

namespace FullCart.Api.Controllers
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

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            return Ok(await _userService.AddUser(user));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _userService.GetAsync(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("done");
        }

        //[HttpPost]
        //[Route("{id}")]
        //public IActionResult Put(int id, User user)
        //{
        //    return Ok("done");
        //}

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("done");
        }
    }
}
