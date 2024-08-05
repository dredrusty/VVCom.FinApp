using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class WalletRepository(FinGoContext context) : RepositoryBase<Wallet>(context), IWalletRepository
{

}
