using FinGo.Services.Interfaces;
using FinGo.DataAccess.UnitOfWork;
using FinGo.DataBase.Models;
using FinGo.Services.Dto;

namespace FinGo.Services;

public class CommentService(IUnitOfWork unitOfWork) : ServiceBase<Comment>(unitOfWork), ICommentService
{
    
}
