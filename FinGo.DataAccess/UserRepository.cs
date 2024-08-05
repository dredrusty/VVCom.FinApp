using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class UserRepository (FinGoContext context) : RepositoryBase<User>(context), IUserRepository
{

}
