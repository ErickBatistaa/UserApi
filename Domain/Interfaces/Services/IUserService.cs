using UsersApi.DTOs;
using UsersApi.Models;

namespace UsersApi.Domain.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User? GetUserById(int id);
        User PutUser(UserDTO user);
        User PostUser(UserDTO user);
        bool DeleteUser(int id);
    }
}
