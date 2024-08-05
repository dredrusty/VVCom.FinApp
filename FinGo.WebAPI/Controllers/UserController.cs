using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;

    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;

        _userService = userService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _userService.GetAll<UserDto>();

        var users = new List<UserResponse>();

        foreach (var result in results)
        {
            var userDto = result as UserDto;
            
            users.Add(userDto!.ToResponse());
        }

        return Ok(users);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = (UserDto)_userService.GetItem<UserDto>(id);

        var user = result.ToResponse();
        
        return user == null ? NotFound() : Ok(user);
    }

    [HttpPut]
    public IActionResult InsertItem(UserRequest userToInsert)
    {
        _userService.InsertItem(userToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(UserRequest userToRemove)
    {
        _userService.RemoveItem(userToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch("Update")]
    public IActionResult UpdateItem(UserRequest userToUpdate)
    {
        _userService.UpdateItem(userToUpdate.ToDomain());

        return Ok();
    }
}
