using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class UserMapper
{
    public static UserDto ToDomain(this UserRequest userRequest)
    {
        var userDto = new UserDto();

        userDto.Id = userRequest.Id;

        userDto.Name = userRequest.Name;

        userDto.Email = userRequest.Email;

        return userDto;
    }

    public static UserRequest ToRequest(this UserDto userDto)
    {
        var userRequest = new UserRequest();

        userRequest.Id = userDto.Id;

        userRequest.Name = userDto.Name;

        userRequest.Email = userDto.Email;

        return userRequest;
    }

    public static UserDto ToDomain(this UserResponse userResponse)
    {
        var userDto = new UserDto();

        userDto.Id = userResponse.Id;

        userDto.Name = userResponse.Name;

        userDto.Email = userResponse.Email;

        return userDto ;
    }

    public static UserResponse ToResponse(this UserDto userDto)
    {
        var userResponse = new UserResponse();

        userResponse.Id = userDto.Id;

        userResponse.Name = userDto.Name;

        userResponse.Email = userDto.Email;

        return userResponse;
    }
}
