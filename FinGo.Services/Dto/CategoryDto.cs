using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class CategoryDto : IDto<Category>
{
    public int Id { get; set; }

    public string? Name { get; set; }
}
