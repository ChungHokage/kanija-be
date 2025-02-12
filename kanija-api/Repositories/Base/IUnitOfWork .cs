namespace kanija_api.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepo<T> Repository<T>() where T : class;

        Task<int> SaveChangesAsync();
    }
}