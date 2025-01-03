﻿using System.Linq.Expressions;

namespace RECIPE_MANAGEMENT_SYSTEM.Contracts
{
    public interface IGenericRepository<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
