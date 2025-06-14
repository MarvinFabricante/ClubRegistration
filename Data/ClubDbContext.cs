using ClubRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubRegistration.Data
{
    public class ClubDbContext : DbContext
    {
        public DbSet<Club> Club { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=ClubDatabase;Username=postgres;Password=passwordnamabangis");
        }
    }
}
