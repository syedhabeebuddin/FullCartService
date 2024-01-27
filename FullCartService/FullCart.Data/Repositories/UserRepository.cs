using FullCart.Data.Repositories.Contracts;
using FullCart.Infrastructure.Database.Context;
using FullCart.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace FullCart.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FullCartDBContext _dbContext;
        public UserRepository(FullCartDBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public async Task<User> AddUserAsync(User user)
        {
            var pp = _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> GetAsync(int id)
        {
            return await _dbContext
                .Users.Where(x => x.Id == id)
                .Include(x => x.Role)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> UpdateAsync(User user)
        {
            var sourceUser = await _dbContext.Users.Where(x => x.Id == user.Id).FirstOrDefaultAsync();
            //sourceRole.Description = role.Description;
            //sourceRole.Name = role.Name;
            var pp = _dbContext.Users.Update(sourceUser);
            await _dbContext.SaveChangesAsync();
            return sourceUser;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            _dbContext.Remove(new User { Id = id });
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
