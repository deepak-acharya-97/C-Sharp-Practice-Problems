using Microsoft.EntityFrameworkCore;

namespace WebApplication3
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }

    }
}