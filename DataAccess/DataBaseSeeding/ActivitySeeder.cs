using Microsoft.EntityFrameworkCore;
using TrabajoNET.Entities;


namespace TrabajoNET.DataAccess.DatabaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>().HasData(
                new Activity
                {
                    Id = 1,
                    Title = "46274628736",
                    Description = "alaskja@sjasja.com",
                    IsCompleted = false,
                    
                },
                new Activity
                {
                    Id = 2,
                    Title = "46278736",
                    Description = "akja@sjasja.com",
                    IsCompleted = false,
                }
            );
        }
    }
}