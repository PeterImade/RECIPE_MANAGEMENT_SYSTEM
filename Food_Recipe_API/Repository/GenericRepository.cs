using System.Linq.Expressions;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.EntityFrameworkCore;
using RECIPE_MANAGEMENT_SYSTEM.Contracts;
using RECIPE_MANAGEMENT_SYSTEM.Data;

namespace RECIPE_MANAGEMENT_SYSTEM.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly RecipeDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(RecipeDBContext recipeDBContext)
        {
            _dbContext = recipeDBContext;
            _dbSet = _dbContext.Set<T>();
        }

        public void Create(T entity) => _dbSet.Add(entity);
         
        public void Delete(T entity) => _dbSet.Remove(entity);
        public IQueryable<T> FindAll(bool trackChanges) => !trackChanges ? _dbSet.AsNoTracking() : _dbSet;

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ? _dbSet.Where(expression).AsNoTracking() : _dbSet.Where(expression);

        public void Update(T entity) => _dbSet.Update(entity);
    }
}
