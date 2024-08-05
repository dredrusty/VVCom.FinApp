using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class CategoryMapper
{
    public static CategoryDto ToDomain(this CategoryRequest categoryRequest)
    {
        var categoryDto = new CategoryDto();

        categoryDto.Id = categoryRequest.Id;

        categoryDto.Name = categoryRequest.Name;

        return categoryDto;
    }
}
