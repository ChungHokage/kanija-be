﻿using kanija_database.EF;
using Microsoft.EntityFrameworkCore;

namespace kanija_api.Repositories.Interfaces
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected readonly KanijaDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepo(KanijaDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}