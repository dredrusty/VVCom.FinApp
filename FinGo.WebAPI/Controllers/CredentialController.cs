using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CredentialController : ControllerBase
{
    private readonly ILogger<CredentialController> _logger;

    private readonly ICredentialService _credentialService;

    public CredentialController(ILogger<CredentialController> logger, ICredentialService credentialService)
    {
        _logger = logger;

        _credentialService = credentialService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _credentialService.GetAll<CredentialDto>();

        var credentials = new List<CredentialResponse>();

        foreach (var result in results)
        {
            var credentialDto = result as CredentialDto;
            
            credentials.Add(credentialDto!.ToResponse());
        }

        return Ok(credentials);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = (CredentialDto)_credentialService.GetItem<CredentialDto>(id);

        var credential = result.ToResponse();

        return credential == null ? NotFound() : Ok(credential);
    }

    [HttpPut]
    public IActionResult InsertItem(CredentialRequest credentialToInsert)
    {
        _credentialService.InsertItem(credentialToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(CredentialRequest credentialToRemove)
    {
        _credentialService.RemoveItem(credentialToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch("Update")]
    public IActionResult UpdateItem(CredentialRequest credentialToUpdate)
    {
        _credentialService.UpdateItem(credentialToUpdate.ToDomain());

        return Ok();
    }
}