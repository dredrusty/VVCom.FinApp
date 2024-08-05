using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class RoleMapper
{
    public static RoleDto ToDomain(this RoleRequest roleRequest)
    {
        var roleDto = new RoleDto();

        roleDto.Id = roleRequest.Id;

        roleDto.Name = roleRequest.Name;

        roleDto.Users = roleRequest.Users.ToList().Select(u => new UserDto() { Id = u.Id, Name = u.Name, Email = u.Email}).ToList();

        return roleDto;
    }

    public static RoleRequest ToRequest(this RoleDto roleDto)
    {
        var roleRequest = new RoleRequest();

        roleRequest.Id = roleDto.Id;

        roleRequest.Name = roleDto.Name;

        roleRequest.Users = roleDto.Users.ToList().Select(u => new UserRequest() { Id = u.Id, Name = u.Name, Email = u.Email }).ToList();

        return roleRequest;
    }

    public static RoleDto ToDomain(this RoleResponse roleResponse)
    {
        var roleDto = new RoleDto();

        roleDto.Id = roleResponse.Id;

        roleDto.Name = roleResponse.Name;

        roleDto.Users = roleResponse.Users.ToList().Select(u => new UserDto() { Id = u.Id, Name = u.Name, Email = u.Email}).ToList();

        return roleDto;
    }

    public static RoleResponse ToResponse(this RoleDto roleDto)
    {
        var roleResponse = new RoleResponse();

        roleResponse.Id = roleDto.Id;

        roleResponse.Name = roleDto.Name;

        roleResponse.Users = roleDto.Users.ToList().Select(u => new UserResponse() { Id = u.Id, Name = u.Name, Email = u.Email }).ToList();

        return roleResponse;
    }
}
