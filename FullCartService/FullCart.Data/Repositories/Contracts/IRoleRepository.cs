using FullCart.Infrastructure.Database.Entities;

namespace FullCart.Data.Repositories.Contracts
{
    public interface IRoleRepository
    {
        Task<Role> AddRoleAsync(Role role);
        Task<Role> GetAsync(int id);
        Task<IEnumerable<Role>> GetAsync();
        Task<Role> UpdateAsync(Role role);
        Task<bool> DeleteAsync(int id);

    }
}
