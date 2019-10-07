using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FestivalVar.Domain;

namespace FestivalVar.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();

        Task<User> GetUserByIdAsync(int userId);
        
        Task<bool> CreateUserAsync(User user);

        Task<bool> UpdateUserAsync(User userToUpdate);

        Task<bool> DeleteUserAsync(int userId);
    }
}