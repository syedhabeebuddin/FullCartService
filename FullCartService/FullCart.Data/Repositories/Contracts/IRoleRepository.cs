using FullCart.Infrastructure.Database.Entities;

namespace FullCart.Data.Repositories.Contracts
{
    public interface IRoleRepository
    {
        Task<Role> AddRoleAsync(Role role);
    }
}
