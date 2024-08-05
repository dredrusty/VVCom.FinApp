namespace FinGo.DataBase.Models;

public class Operation
{
    public int Id { get; set; }

    public decimal Sum { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Comment> Comment { get; set; } = [];
}
