using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;
using FinGo.Services.Interfaces;

namespace FinGo.Services;

public class CredentialService(IUnitOfWork unitOfWork) : ServiceBase<Credential>(unitOfWork), ICredentialService
{
    
}
