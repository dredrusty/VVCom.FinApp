using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class CredentialRepository(FinGoContext context) : RepositoryBase<Credential>(context), ICredentialRepository
{

}
