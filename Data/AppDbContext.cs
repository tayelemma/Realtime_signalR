using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Realtime_signalR.Models;

namespace Realtime_signalR.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext( IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"),
                    optionsBuilder => optionsBuilder.EnableRetryOnFailure());
            }   
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
    }
}
