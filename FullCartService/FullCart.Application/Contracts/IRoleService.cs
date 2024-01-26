using FullCart.Domain.Models;

namespace FullCart.Application.Contracts
{
    public interface IRoleService
    {
        Task<Role> AddRole(Role role);
        Task<Role> GetAsync(int id);
        Task<Role> UpdateAsync(int id, Role role);
        Task<bool> DeleteAsync(int id);
    }
}
