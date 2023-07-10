using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<UYUrunler> UYUrunler { get; set; }
        public DbSet<UYIsEmri> UYIsEmri { get; set; }
        public DbSet<UYIsEmriRotasi> UYIsEmriRotasi { get; set; }
        public DbSet<UYIsEmriDurumu> UYIsEmriDurumu { get; set; }
        public DbSet<UYKonumTuru> UYKonumTuru { get; set; }
        public DbSet<UYKonum> UYKonum { get; set; }
    }
}
