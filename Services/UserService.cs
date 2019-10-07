using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Data;
using FestivalVar.Domain;
using Microsoft.EntityFrameworkCore;

namespace FestivalVar.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dataContext.UsersContext.ToListAsync();
        }

        public async Task<bool> CreateUserAsync(User user)
        {
            await _dataContext.UsersContext.AddAsync(user);

            var created = await _dataContext.SaveChangesAsync();

            return created > 0;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _dataContext.UsersContext.SingleOrDefaultAsync(x =>  x.Id == userId);
        }

        public async Task<bool> UpdateUserAsync(User userToUpdate)
        {
            _dataContext.UsersContext.Update(userToUpdate);

            var updated = await _dataContext.SaveChangesAsync();

            return updated > 0;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await GetUserByIdAsync(userId);

            if (user == null)
            {
                return false;
            }

            _dataContext.UsersContext.Remove(user);

            var deleted = await _dataContext.SaveChangesAsync();

            return deleted > 0;
        }
    }
}