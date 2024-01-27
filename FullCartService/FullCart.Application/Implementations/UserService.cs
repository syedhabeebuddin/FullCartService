using FullCart.Application.Contracts;
using FullCart.Data.Repositories.Contracts;
using User = FullCart.Domain.Models.User;

namespace FullCart.Application.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public async Task<User> AddUser(User user)
        {
            var eUser = new Infrastructure.Database.Entities.User()
            {
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                //Role = new Infrastructure.Database.Entities.Role { Id = 2},
                RoleId = 2,
                IsActive = true,
                Username = user.Username                
            };

            var result = await _repository.AddUserAsync(eUser);
            return new User {  Username = user.Username };
        }

        public async Task<User> GetAsync(int id)
        {
            var result = await _repository.GetAsync(id);
            return new User { Username = result.Username };
        }

        public async Task<User> UpdateAsync(int id, User user)
        {
            //var eRole = new Infrastructure.Database.Entities.Role()
            //{
            //    Id = id,
            //    UpdatedBy = 1,
            //    UpdatedOn = DateTime.Now,
            //    Description = role.Description,
            //    Name = role.Name
            //};
            //var result = await _repository.UpdateAsync(eRole);
            return user;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
