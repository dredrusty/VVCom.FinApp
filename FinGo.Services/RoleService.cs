using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;
using FinGo.Services.Interfaces;

namespace FinGo.Services;

public class RoleService(IUnitOfWork unitOfWork) : ServiceBase<Role>(unitOfWork), IRoleService
{
    
}
