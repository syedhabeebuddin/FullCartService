using FullCart.Domain.Models;

namespace FullCart.Application.Contracts
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        Task<User> GetAsync(int id);
        Task<User> UpdateAsync(int id, User user);
        Task<bool> DeleteAsync(int id);
    }
}
