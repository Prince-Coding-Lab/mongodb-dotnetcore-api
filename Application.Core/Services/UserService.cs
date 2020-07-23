using Application.Core.Interfaces;
using Application.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoRepository<Users> _userRepository;
        public UserService(IMongoRepository<Users> userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<Users> CreateUserAsync(Users user)
        {
            await _userRepository.InsertOneAsync(user);
            return user;
        }

        public Task DeleteUserAsync(Users user)
        {
            throw new NotImplementedException();
        }

        public async Task<Users> GetUserByIdAsync(string id)
        {
            return await _userRepository.FindByIdAsync(id);
        }

        public Task<Users> GetUsersAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUserAsync(Users user)
        {
            await _userRepository.ReplaceOneAsync(user);
           
        }
    }
}
