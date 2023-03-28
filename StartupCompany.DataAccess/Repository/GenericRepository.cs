using StartupCompany.DataAccess.Context;
using StartupCompany.Domain.Interface;
using System.Linq.Expressions;

namespace StartupCompany.DataAccess.Repository;
public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public readonly StartupCompanyDbContext _context;
    public GenericRepository(StartupCompanyDbContext context)
    {
        _context = context;
    }
    public IEnumerable<T> AddMultiple(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);

        return entities;
    }

    public T AddOne(T entity)
    {
        _context.Set<T>().Add(entity);

        return entity;
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().Where(predicate);
    }

    public T Get(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public bool RemoveMultiple(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);

        return true;
    }

    public bool RemoveOne(T entity)
    {
        _context.Set<T>().Remove(entity);

        return true;
    }
}
