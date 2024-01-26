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
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _roleService.GetAsync(id));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("done");
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Put(int id, Role role)
        {
            return Ok(await _roleService.UpdateAsync(id,role));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _roleService.DeleteAsync(id));
        }
    }
}
