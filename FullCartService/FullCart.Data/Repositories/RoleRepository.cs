using FullCart.Data.Repositories.Contracts;
using FullCart.Infrastructure.Database.Context;
using FullCart.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

        public async Task<Role> GetAsync(int id)
        {
            return await _dbContext.Roles.Where(x => x.Id == id)?.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Role>> GetAsync()
        {
            return await _dbContext.Roles.ToListAsync();
        }

        public async Task<Role> UpdateAsync(Role role)
        {
            var sourceRole = await _dbContext.Roles.Where(x => x.Id == role.Id).FirstOrDefaultAsync();
            sourceRole.Description = role.Description;
            sourceRole.Name = role.Name;
            var pp = _dbContext.Roles.Update(sourceRole);
            await _dbContext.SaveChangesAsync();
            return sourceRole;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _dbContext.Remove(new Role { Id = id });
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
