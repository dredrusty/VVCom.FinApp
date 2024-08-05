using FinGo.Services.Interfaces;
using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;

namespace FinGo.Services;

public class CategoryService(IUnitOfWork unitOfWork) : ServiceBase<Category>(unitOfWork), ICategoryService
{
    
}
