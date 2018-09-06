using Microsoft.EntityFrameworkCore;

namespace Practice_01
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}