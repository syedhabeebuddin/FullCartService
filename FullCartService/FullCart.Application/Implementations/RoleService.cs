using FullCart.Application.Contracts;
using FullCart.Data.Repositories.Contracts;
using FullCart.Domain.Models;

namespace FullCart.Application.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }
        public async Task<Role> AddRole(Role role)
        {
            var eRole = new Infrastructure.Database.Entities.Role()
            {
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                Description = role.Description,
                Name = role.Name
            };

            var result = await _repository.AddRoleAsync(eRole);
            return new Role { Name = result.Name, Description = result.Description };            
        }
    }
}
