using FinGo.DataAccess.Interfaces;
using FinGo.DataBase.Models;
using FinGo.DataBase;


namespace FinGo.DataAccess;

public class CommentRepository(FinGoContext context) : RepositoryBase<Comment>(context), ICommentRepository
{

}
