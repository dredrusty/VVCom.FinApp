namespace FinGo.Services.Mappers;

public interface IDto<TEntity>
{
    public TEntity ToModel();

    public IDto<TEntity> FromModel(TEntity model);
}
