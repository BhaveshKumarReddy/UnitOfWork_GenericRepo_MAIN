using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace UnitOfWork_GenericRepo_MAIN.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<ActionResult<List<T>>> GetAllAsync();
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, string? includeProperties = null);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}
