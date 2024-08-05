using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class OperationRepository(FinGoContext context) : RepositoryBase<Operation>(context), IOperationRepository
{

}
