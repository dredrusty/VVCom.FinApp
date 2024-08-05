﻿namespace FinGo.WebAPI.Model;

public class CommentRequest
{
    public int Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}
