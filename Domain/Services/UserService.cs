using UsersApi.Domain.Interfaces.Repositories;
using UsersApi.Domain.Interfaces.Services;
using UsersApi.DTOs;
using UsersApi.Models;

namespace UsersApi.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.Delete(id);
        }

        public User? GetUserById(int id)
        {
            return _userRepository.FindOne(id);
        }

        public List<User> GetUsers()
        {
            return _userRepository.FindAll();
        }

        public User PostUser(UserDTO user)
        {
            User entity = new User(user);   
            return _userRepository.Post(entity);
        }

        public User PutUser(UserDTO user)
        {
            User entity = new User(user);
            return _userRepository.Update(entity);
        }
    }
}
