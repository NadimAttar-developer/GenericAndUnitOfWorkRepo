using System;
using System.Linq.Expressions;

namespace StartupCompany.Domain.Interface;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T Get(int id);
    IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    T AddOne(T entity);
    IEnumerable<T> AddMultiple(IEnumerable<T> entities);
    bool RemoveOne(T entity);
    bool RemoveMultiple(IEnumerable<T> entities);

}
