using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OperationController : ControllerBase
{
    private readonly ILogger<OperationController> _logger;

    private readonly IOperationService _operationService;

    public OperationController(ILogger<OperationController> logger, IOperationService operationService)
    {
        _logger = logger;

        _operationService = operationService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _operationService.GetAll<OperationDto>();

        var operations = new List<OperationResponse>();

        foreach (var result in results)
        {
            var operationDto = result as OperationDto;
            
            operations.Add(operationDto!.ToResponse());
        }

        return Ok(operations);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = (OperationDto)_operationService.GetItem<OperationDto>(id);

        var operation = result.ToResponse();
 
        return operation == null ? NotFound() : Ok(operation);
    }

    [HttpPut]
    public IActionResult Insert(OperationRequest operationToInsert)
    {        
        _operationService.InsertItem(operationToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(OperationRequest operationToRemove)
    {        
        _operationService.RemoveItem(operationToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch("Update")]
    public IActionResult UpdateItem(OperationRequest operationToUpdate)
    {        
        _operationService.UpdateItem(operationToUpdate.ToDomain());

        return Ok();
    }
}
