using Microsoft.EntityFrameworkCore;

namespace CRUDSqlite
{
    public class ItemsContext : DbContext
    {
        public DbSet<Items> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source=.\ItemsDB.db");

        }
    }
}
