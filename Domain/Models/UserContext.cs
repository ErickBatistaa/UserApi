using Microsoft.EntityFrameworkCore;

namespace UsersApi.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public UserContext(DbContextOptions<UserContext> options) : base(options) {}

    }
}
