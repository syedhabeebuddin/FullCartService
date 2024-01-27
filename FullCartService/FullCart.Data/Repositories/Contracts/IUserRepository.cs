using FullCart.Infrastructure.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullCart.Data.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<User> AddUserAsync(User user);
        Task<User> GetAsync(int id);
        Task<IEnumerable<User>> GetAsync();
        Task<User> UpdateAsync(User user);
        Task<bool> DeleteAsync(int id);
    }
}
