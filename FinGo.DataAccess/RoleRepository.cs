using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class RoleRepository(FinGoContext context) : RepositoryBase<Role>(context), IRoleRepository
{

}
