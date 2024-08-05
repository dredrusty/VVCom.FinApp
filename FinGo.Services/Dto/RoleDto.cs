using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class RoleDto : IDto<Role>
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<UserDto> Users { get; set; } = [];
}
