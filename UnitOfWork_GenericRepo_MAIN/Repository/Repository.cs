using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using UnitOfWork_GenericRepo_MAIN.Models;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ShoppingContext _db;

        internal DbSet<T> dbSet;
        public Repository(ShoppingContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<ActionResult<List<T>>> GetAllAsync()
        {
            var x = await dbSet.ToListAsync();
            return x;
        }

        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
