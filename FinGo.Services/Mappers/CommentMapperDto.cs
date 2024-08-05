using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class CommentDto : IDto<Comment>
{
    public Comment ToModel()
    {
        var comment = new Comment();

        comment.Id = Id;

        comment.Text = Text;

        comment.CreatedAt = CreatedAt;

        return comment;
    }

    public IDto<Comment> FromModel(Comment comment)
    {
        var commentDto = new CommentDto();

        commentDto.Id = comment.Id;

        commentDto.Text = comment.Text;

        commentDto.CreatedAt = comment.CreatedAt;

        return commentDto;
    }
}
