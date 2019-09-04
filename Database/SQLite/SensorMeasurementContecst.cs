using Microsoft.EntityFrameworkCore;
using WetherServer.Database.Clases;

namespace WetherServer.Database.SQLite
{
    public class SensorMeasurementContecst : DbContext
    {
        public SensorMeasurementContecst()
        {
            Database.EnsureCreated();
        }

        public DbSet<SensorMeasurement> SensorMeasurements { get; set; }

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
