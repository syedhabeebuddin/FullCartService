using FullCart.Data.Repositories.Contracts;
using FullCart.Infrastructure.Database.Context;
using FullCart.Infrastructure.Database.Entities;

namespace FullCart.Data.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly FullCartDBContext _dbContext;
        public RoleRepository(FullCartDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<Role> AddRoleAsync(Role role)
        {
            var pp = _dbContext.Roles.Add(role);
            await _dbContext.SaveChangesAsync();
            return role;
        }
    }
}
