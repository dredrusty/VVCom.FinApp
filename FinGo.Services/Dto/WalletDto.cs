using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class WalletDto : IDto<Wallet>
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
}
