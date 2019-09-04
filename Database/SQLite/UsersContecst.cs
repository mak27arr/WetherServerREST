using Microsoft.EntityFrameworkCore;
using WetherServer.Database.Clases;

namespace WetherServer.Database.SQLite
{
    public class UsersContecst : DbContext
    {
        public UsersContecst()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data Source=d:\WetherDB.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
