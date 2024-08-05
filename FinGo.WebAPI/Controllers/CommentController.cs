using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
    private readonly ILogger<CommentController> _logger;

    private readonly ICommentService _commentService;

    public CommentController(ILogger<CommentController> logger, ICommentService commentService)
    {
        _logger = logger;

        _commentService = commentService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var comments = new List<CommentResponse>();

        var results = _commentService.GetAll<CommentDto>();

        foreach (var result in results)
        {
            var commentDto = result as CommentDto;
            
            comments.Add(commentDto!.ToResponse());
        }

        return Ok(comments);
    }
    
    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = (CommentDto)_commentService.GetItem<CommentDto>(id);

        var comment = result.ToResponse();

        return comment == null ? NotFound() : Ok(comment);
    }

    [HttpPut]
    public IActionResult InsertItem(CommentRequest commentToInsert)
    {
        _commentService.InsertItem(commentToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(CommentRequest commentToRemove)
    {
       _commentService.RemoveItem(commentToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch("Update")]
    public IActionResult UpdateItem(CommentRequest commentToUpdate)
    {        
        _commentService.UpdateItem(commentToUpdate.ToDomain());

        return Ok();
    }
}
