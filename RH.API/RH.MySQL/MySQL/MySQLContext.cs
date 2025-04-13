using Microsoft.EntityFrameworkCore;

namespace RH.MySQL.MySQL
{
    public class MySQLContext : DbContext
    {
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
            // For example:
            // modelBuilder.Entity<YourEntity>().ToTable("YourTableName");
        }
    }
}
