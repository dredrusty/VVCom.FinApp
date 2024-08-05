using FinGo.Services.Dto;
using FinGo.Services.Interfaces;
using FinGo.WebAPI.Mappers;
using FinGo.WebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace FinGo.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WalletController : ControllerBase
{
    private readonly ILogger<WalletController> _logger;

    private readonly IWalletService _walletService;

    public WalletController(ILogger<WalletController> logger, IWalletService walletService)
    {
        _logger = logger;

        _walletService = walletService;
    }

    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var results = _walletService.GetAll<WalletDto>();

        var wallets = new List<WalletResponse>();

        foreach (var result in results)
        {
            var walletDto = result as WalletDto;
            
            wallets.Add(walletDto!.ToResponse());
        }
        
        return Ok(wallets);
    }

    [HttpGet("Get/{id}")]
    public IActionResult GetItem(int id)
    {
        var result = (WalletDto)_walletService.GetItem<WalletDto>(id);

        var wallet = result.ToResponse();

        return wallet == null ? NotFound() : Ok(wallet);
    }

    [HttpPut]
    public IActionResult InsertItem(WalletRequest walletToInsert)
    {
        _walletService.InsertItem(walletToInsert.ToDomain());

        return Ok();
    }

    [HttpDelete]
    public IActionResult RemoveItemById(WalletRequest walletToRemove)
    {
        _walletService.RemoveItem(walletToRemove.ToDomain());

        return Ok();
    }

    [HttpPatch("Update")]
    public IActionResult UpdateItem(WalletRequest walletToUpdate)
    {
        _walletService.UpdateItem(walletToUpdate.ToDomain());

        return Ok();
    }
}
