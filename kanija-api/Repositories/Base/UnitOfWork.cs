using kanija_database.EF;

namespace kanija_api.Repositories.Interfaces
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly KanijaDbContext _context;
        private readonly Dictionary<Type, object> _repositories = new();

        public UnitOfWork(KanijaDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IBaseRepo<T> Repository<T>() where T : class
        {
            if (!_repositories.ContainsKey(typeof(T)))
            {
                _repositories[typeof(T)] = new BaseRepo<T>(_context);
            }

            return (IBaseRepo<T>)_repositories[typeof(T)];
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}