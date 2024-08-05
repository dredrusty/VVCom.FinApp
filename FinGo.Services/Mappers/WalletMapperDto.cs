using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class WalletDto : IDto<Wallet>
{
    public Wallet ToModel()
    {
        var wallet = new Wallet();

        wallet.Id =Id;

        wallet.Name = Name;

        return wallet;
    }

    public IDto<Wallet> FromModel(Wallet wallet)
    {
        var walletDto = new WalletDto();

        walletDto.Id = wallet.Id;

        walletDto.Name = wallet.Name;

       return walletDto;
    }
}
