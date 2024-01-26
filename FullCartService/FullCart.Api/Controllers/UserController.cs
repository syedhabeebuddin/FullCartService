using FullCart.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullCart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            return Ok("done");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("done");
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
