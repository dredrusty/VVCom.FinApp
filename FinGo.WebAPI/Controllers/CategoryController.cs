using Microsoft.AspNetCore.Mvc;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Model;
using AutoMapper;
using FinGo.Services.Dto;
using FinGo.WebAPI.Mappers;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CategoryController : ControllerBase
{
    private readonly ILogger<CategoryController> _logger;

    private readonly ICategoryService _categoryService;

    private readonly IMapper _mapper;

    public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService, IMapper mapper)
    {
        _logger = logger;

        _categoryService = categoryService;

        _mapper = mapper;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _categoryService.GetAll<CategoryDto>();

        var categories = new List<CategoryResponse>();

        foreach (var result in results)
        {
            var categoryDto = result as CategoryDto;
            
            categories.Add(_mapper.Map<CategoryResponse>(categoryDto)); 
        }

        return Ok(categories);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = _categoryService.GetItem<CategoryDto>(id);

        var category = _mapper.Map<CategoryResponse>(result);

        return category == null ? NotFound() : Ok(category);
    }

    [HttpPut]
    public IActionResult InsertItem(CategoryRequest category)
    {
        _categoryService.InsertItem(_mapper.Map<CategoryDto>(category));

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(CategoryRequest categoryToRemove)
    {       
        _categoryService.RemoveItem(categoryToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch]
    public IActionResult Update(CategoryRequest category)
    {     
        _categoryService.UpdateItem(_mapper.Map<CategoryDto>(category));

        return Ok();
    }
}
