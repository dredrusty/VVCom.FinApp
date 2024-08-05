using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class RoleDto : IDto<Role>
{
    public Role ToModel()
    {
        var role = new Role();

        role.Id = Id;

        role.Name = Name;

        role.User = Users.ToArray().Select(u => new User() { Id = u.Id, Name = u.Name, Email = u.Email }).ToArray();

        return role;
    }

    public IDto<Role> FromModel(Role role)
    {
        var roleDto = new RoleDto();

        roleDto.Id = role.Id;

        roleDto.Name = role.Name;

        roleDto.Users = role.User.ToList().Select(u => new UserDto() { Id = u.Id, Name = u.Name, Email = u.Email }).ToList();

        return roleDto;
    }
}
