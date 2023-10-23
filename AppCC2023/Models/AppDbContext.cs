using Microsoft.EntityFrameworkCore;

namespace AppCC2023.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<MSOffice> MSOffices { get; set; }

    }
}
