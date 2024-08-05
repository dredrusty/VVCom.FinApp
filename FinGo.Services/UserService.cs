using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;
using FinGo.Services.Interfaces;

namespace FinGo.Services;

public class UserService(IUnitOfWork unitOfWork) : ServiceBase<User>(unitOfWork), IUserService
{
    
}
