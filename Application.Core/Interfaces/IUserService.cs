using Application.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Interfaces
{
    public interface IUserService
    {
        Task<Users> CreateUserAsync(Users user);
        Task UpdateUserAsync(Users user);
        Task DeleteUserAsync(Users user);
        Task<Users> GetUserByIdAsync(string id);
        Task<Users> GetUsersAsync(string id);
    }
}
