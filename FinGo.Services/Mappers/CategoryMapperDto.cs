using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class CategoryDto : IDto<Category>
{
    public Category ToModel()
    {
        var category = new Category();

        category.Id = Id;

        category.Name = Name!;

        return category;
    }

    public IDto<Category> FromModel(Category category)
    {
        var categoryDto = new CategoryDto();

        categoryDto.Id = category.Id;

        categoryDto.Name = category.Name!;

        return categoryDto;
    }
}
