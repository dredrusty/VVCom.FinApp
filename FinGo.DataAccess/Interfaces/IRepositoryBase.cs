namespace FinGo.DataAccess.Interfaces;

public interface IRepositoryBase<TEntity> : IDisposable
        where TEntity : class
{
    IEnumerable<TEntity> GetAll();

    TEntity GetItem(int id);

    TEntity InsertItem(TEntity item);

    void UpdateItem(TEntity item);

    void RemoveItem(TEntity item);

    void RemoveById(int id);
}