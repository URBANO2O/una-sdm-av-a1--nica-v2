using Microsoft.EntityFrameworkCore;
using PetroAtivos324133695.Models;

namespace PetroAtivos324133695.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ativo> Ativos { get; set; }
    }
}
