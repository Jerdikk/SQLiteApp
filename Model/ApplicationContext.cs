using Microsoft.EntityFrameworkCore;

namespace SQLiteApp
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
