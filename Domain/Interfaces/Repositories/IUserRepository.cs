using UsersApi.DTOs;
using UsersApi.Models;

namespace UsersApi.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        List<User> FindAll();
        User? FindOne(int id);
        User Update(User user);
        User Post(User user);
        bool Delete(int id);
    }
}
