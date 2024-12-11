using System.Linq.Expressions;

namespace RECIPE_MANAGEMENT_SYSTEM.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression = null, bool tracked = true);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> expression = null, bool tracked = true);
        Task SaveAsync();
    }
}
