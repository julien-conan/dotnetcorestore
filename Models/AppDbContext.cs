using Microsoft.EntityFrameworkCore;

namespace dotnetcorestore.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Paiement> Paiements { get; set; }
    }
}