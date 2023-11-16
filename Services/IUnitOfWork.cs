using TrabajoNET.Repository;

namespace TrabajoNET.Services
{
    public interface IUnitOfWork
    {
        public ActivityRepository ActivityRepository { get; set; }

        public Task<int> Complete();
    }
}