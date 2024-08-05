using FinGo.Services.Dto;
using FinGo.WebAPI.Model;


namespace FinGo.WebAPI.Mappers;

public static class CommentMapper
{
    public static CommentDto ToDomain(this CommentRequest commentRequest)
    {
        var commentDto = new CommentDto();

        commentDto.Id = commentRequest.Id;

        commentDto.Text = commentRequest.Text;

        commentDto.CreatedAt = commentRequest.CreatedAt;

        return commentDto;
    }

    public static CommentRequest ToRequest(this CommentDto commentDto)
    {
        var commentRequest = new CommentRequest();

        commentRequest.Id = commentDto.Id;

        commentRequest.Text = commentDto.Text;

        commentRequest.CreatedAt = commentDto.CreatedAt;

        return commentRequest;
    }

    public static CommentDto ToDomain(this CommentResponse commentResponse)
    {
        var commentDto = new CommentDto();

        commentDto.Id = commentResponse.Id;

        commentDto.Text = commentResponse.Text;

        commentDto.CreatedAt = commentResponse.CreatedAt;

        return commentDto;
    }

    public static CommentResponse ToResponse(this CommentDto commentDto)
    {
        var commentResponse = new CommentResponse();

        commentResponse.Id = commentDto.Id;

        commentResponse.Text = commentDto.Text;

        commentResponse.CreatedAt = commentDto.CreatedAt;

        return commentResponse;
    }
}
