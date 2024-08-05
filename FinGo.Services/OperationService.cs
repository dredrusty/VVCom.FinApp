using FinGo.Services.Interfaces;
using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;

namespace FinGo.Services;

public class OperationService(IUnitOfWork unitOfWork) : ServiceBase<Operation>(unitOfWork), IOperationService
{
    
}
