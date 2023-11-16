using TrabajoNET.DataAccess;
using TrabajoNET.Repository;

namespace TrabajoNET.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly ContextDB _contextDB;
        public ActivityRepository ActivityRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB)
        {
            _contextDB = contextDB;
            ActivityRepository = new ActivityRepository(contextDB);
        }

        public Task<int> Complete()
        {
            return _contextDB.SaveChangesAsync();
        }
    }
}