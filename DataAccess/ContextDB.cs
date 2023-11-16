using Microsoft.EntityFrameworkCore;
using TrabajoNET.DataAccess.DatabaseSeeding;
using TrabajoNET.Entities;


namespace TrabajoNET.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder>
        {
            new ActivitySeeder(),
        };

            foreach (var seeder in seeders)
            {
                seeder.SeedDatabase(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}