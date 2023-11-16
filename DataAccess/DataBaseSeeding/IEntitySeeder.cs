using Microsoft.EntityFrameworkCore;

namespace TrabajoNET.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}