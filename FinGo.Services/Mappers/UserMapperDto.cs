using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class UserDto : IDto<User>
{
    public User ToModel()
    {
        var user = new User();

        user.Id = Id;

        user.Name = Name;

        user.Email = Email;

        return user;
    }

    public IDto<User> FromModel( User user)
    {
        var userDto = new UserDto();

        userDto.Id = user.Id;

        userDto.Name = user.Name;

        userDto.Email = user.Email;

        return userDto;
    }
}
