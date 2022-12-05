using UsersApi.Domain.Interfaces.Repositories;
using UsersApi.DTOs;
using UsersApi.Models;

namespace UsersApi.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public List<User> FindAll()
        {
            return _context.Users.ToList();
        }

        public User? FindOne(int id)
        {
            return _context.Users.FirstOrDefault(x => x.UserId == id);
        }

        public User Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            
            return user;
        }

        public User Post(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public bool Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserId == id);
            if(user == null) return false;
            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
    }
}
