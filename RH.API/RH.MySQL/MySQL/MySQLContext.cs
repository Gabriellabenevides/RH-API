using Microsoft.EntityFrameworkCore;
using RH.Domain.Entities;

namespace RH.MySQL.MySQL
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
            // For example:
            // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
        }
    }
}
