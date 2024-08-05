using FinGo.Services.Mappers;

namespace FinGo.Services.Interfaces;

public interface IServiceBase<TEntity>
    where TEntity : class
{
    IDto<TEntity> GetItem<TDto>(int id)
        where TDto : IDto<TEntity>, new();

    IEnumerable<IDto<TEntity>> GetAll<TDto>()
        where TDto : IDto<TEntity>, new();

    public IDto<TEntity> InsertItem<TDto>(TDto item)
        where TDto : IDto<TEntity>, new();

    void RemoveItem<TDto>(TDto item)
        where TDto : IDto<TEntity>;

    void UpdateItem<TDto>(TDto item)
        where TDto : IDto<TEntity>;
}
