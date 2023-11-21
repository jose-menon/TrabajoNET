using Microsoft.EntityFrameworkCore;
using TrabajoNET.Entities;


namespace TrabajoNET.DataAccess.DatabaseSeeding
{
    public class ActivitySeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(
                new Activity
                {
                    Id = 1,
                    Title = "prueba",
                    Description = "elemento prueba",
                    IsCompleted = false,
                    
                },
                new Activity
                {
                    Id = 2,
                    Title = "salir",
                    Description = "tomar aire",
                    IsCompleted = false,
                }
            );
        }
    }
}