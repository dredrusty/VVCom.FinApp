using FinGo.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinGo.DataAccess;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> 
    where TEntity : class
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    private bool disposed = false;

    public RepositoryBase(DbContext context)
    {
        _context = context;

        _dbSet = context.Set<TEntity>();
    }

    public TEntity GetItem(int id)
    {
        return _dbSet.Find(id)!;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }

    public TEntity InsertItem(TEntity item)
    {
        var newEntity = _dbSet.Add(item);
        return newEntity.Entity;
    }

    public void RemoveItem(TEntity item)
    {
        _dbSet.Remove(item);
    }

    public void RemoveById(int id)
    {
        var item = _dbSet.Find(id);
        
        RemoveItem(item!);
    }

    public void UpdateItem(TEntity item)
    {
        _context.Entry(item).State = EntityState.Modified;
    }

    public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        return Include(includeProperties).ToList();
    }

    public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        var query = Include(includeProperties);
        return query.Where(predicate).ToList();
    }

    private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = _dbSet.AsNoTracking();
        return includeProperties
            .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
    }

    public virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
