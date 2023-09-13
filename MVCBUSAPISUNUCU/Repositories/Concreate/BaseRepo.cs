using Microsoft.EntityFrameworkCore;
using MVCBUSAPI.Data;
using MVCBUSAPI.Repositories.Abstract;
using System;
using System.Linq.Expressions;

namespace MVCBUSAPI.Repositories.Concreate
{
    public abstract class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly OtobüsDBContext _db;
        private readonly DbSet<T> _dbSet;

        public BaseRepo(OtobüsDBContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }
        public async Task<T> Create(T entity)
        {
            _db.Entry(entity).State = EntityState.Added;
            return await _db.SaveChangesAsync() > 0 ? entity : null;

        }

        public async Task Delete(T entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
        }

        public async Task<T> FindById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>> expression = null)
        {
            IQueryable<T> query = _dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            return await query.ToListAsync();
        }

        public async Task<T> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            return await _db.SaveChangesAsync() > 0 ? entity : null;
        }
    }
}
