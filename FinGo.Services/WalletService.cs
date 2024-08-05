using FinGo.Services.Interfaces;
using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;

namespace FinGo.Services;

public class WalletService(IUnitOfWork unitOfWork) : ServiceBase<Wallet>(unitOfWork), IWalletService
{
    
}
