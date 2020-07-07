using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApi.Entities;

namespace WebApi.Persistence
{
    public class DataContext : DbContext
    {       
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions options)
        : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}