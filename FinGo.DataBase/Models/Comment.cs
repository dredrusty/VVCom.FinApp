namespace FinGo.DataBase.Models;

public class  Comment
{
    public int Id { get; set; }

    public string Text { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public virtual Operation Operation { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
