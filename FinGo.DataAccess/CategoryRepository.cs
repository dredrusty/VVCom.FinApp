using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;

namespace FinGo.DataAccess;

public class CategoryRepository(FinGoContext context) : RepositoryBase<Category>(context), ICategoryRepository
{

}
