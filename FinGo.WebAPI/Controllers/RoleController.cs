using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;


namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoleController : ControllerBase
{
    private readonly ILogger<RoleController> _logger;

    private readonly IRoleService _roleService;

    public RoleController(ILogger<RoleController> logger, IRoleService roleService)
    {
        _logger = logger;

        _roleService = roleService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _roleService.GetAll<RoleDto>();

        var roles = new List<RoleResponse>();

        foreach (var result in results)
        {
            var roleDto = result as RoleDto;
            
            roles.Add(roleDto!.ToResponse());
        }

        return Ok(roles);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id) 
    {
        var result = (RoleDto)_roleService.GetItem<RoleDto>(id);

        var role = result.ToResponse();

        return role == null ? NotFound() : Ok(role);   
    }

    [HttpPut]
    public IActionResult Insert(RoleRequest roleToInsert)
    {
        _roleService.InsertItem(roleToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult Remove(RoleRequest roleToRemove)
    {        
        _roleService.RemoveItem(roleToRemove.ToDomain());

        return Ok();
    }
}
