using FullCart.Application.Contracts;
using FullCart.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullCart.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Role role)
        {            
            return Ok(await _roleService.AddRole(role));
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

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, Role role)
        {
            return Ok("done");
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("done");
        }
    }
}
