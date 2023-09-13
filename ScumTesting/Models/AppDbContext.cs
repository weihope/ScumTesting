using Microsoft.EntityFrameworkCore;

namespace ScumTesting.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> User { get; set; } = null!;

    }
}
