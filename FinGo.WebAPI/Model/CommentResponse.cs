namespace FinGo.WebAPI.Model;

public class CommentResponse
{
    public int Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}
