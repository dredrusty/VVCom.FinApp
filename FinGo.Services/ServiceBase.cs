using FinGo.DataAccess.UnitOfWork;
using FinGo.Services.Interfaces;
using FinGo.Services.Mappers;

namespace FinGo.Services;

public class ServiceBase<TEntity> : IServiceBase<TEntity>
    where TEntity : class
{
    private readonly IUnitOfWork _unitOfWork;

    public ServiceBase(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void RemoveItem<TDto>(TDto itemDto)
        where TDto : IDto<TEntity>
    {
        var item = itemDto.ToModel();

        _unitOfWork.GetRepository<TEntity>().RemoveItem(item);

        _unitOfWork.Commit();
    }

    public IDto<TEntity> GetItem<TDto>(int id)
        where TDto : IDto<TEntity>, new()
    {
        var entity =  _unitOfWork.GetRepository<TEntity>().GetItem(id);

        var result = new TDto();

        return result.FromModel(entity);
    }

    public IEnumerable<IDto<TEntity>> GetAll<TDto>()
        where TDto : IDto<TEntity>, new()
    {
        var result = new List<IDto<TEntity>>();
        
        var entities = _unitOfWork.GetRepository<TEntity>().GetAll();

        foreach (var entity in entities)
        {
            var dto = new TDto();

            result.Add(dto.FromModel(entity));
        }

        return result;
    }

    public IDto<TEntity> InsertItem<TDto>(TDto item)
        where TDto: IDto<TEntity>, new ()
    {
        var newItem = item.ToModel();
        
        var newEntity = _unitOfWork.GetRepository<TEntity>().InsertItem(newItem);

        _unitOfWork.Commit();

        return (IDto<TEntity>)newEntity;
    }

    public void UpdateItem<TDto>(TDto item)
        where TDto : IDto<TEntity>
    {
        var newItem = item.ToModel();
        
        _unitOfWork.GetRepository<TEntity>().UpdateItem(newItem);

        _unitOfWork.Commit();
    }
}
