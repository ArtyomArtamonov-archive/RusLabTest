using Microsoft.EntityFrameworkCore;
using RusLabTest.Models;

namespace RusLabTest.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"));
        }
    }
}
