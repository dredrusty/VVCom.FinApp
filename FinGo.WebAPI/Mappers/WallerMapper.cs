using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class WallerMapper
{
    public static WalletDto ToDomain(this WalletRequest walletRequest)
    {
        var walletDto = new WalletDto();

        walletDto.Id = walletRequest.Id;

        walletDto.Name = walletRequest.Name;

        return walletDto;
    }

    public static WalletRequest ToRequest(this WalletDto walletDto)
    {
        var walletRequest = new WalletRequest();

        walletRequest.Id = walletDto.Id;

        walletRequest.Name = walletDto.Name;

       return walletRequest;
    }

    public static WalletDto ToDomain(this WalletResponse walletResponse)
    {
        var walletDto = new WalletDto();

        walletDto.Id = walletResponse.Id;

        walletDto.Name = walletResponse.Name;

        return walletDto;
    }

    public static WalletResponse ToResponse(this WalletDto walletDto)
    {
        var walletResponse = new WalletResponse();

        walletResponse.Id = walletDto.Id;

        walletResponse.Name = walletDto.Name;

        return walletResponse;
    }
}
