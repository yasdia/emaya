using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Yasm.Dao.Repos.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        IEnumerable<T> FindAll();
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
