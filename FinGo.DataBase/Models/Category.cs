namespace FinGo.DataBase.Models;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual Category? ParentCategory { get; set; }

    public virtual Wallet Wallet { get; set; } = null!;

    public virtual ICollection<Operation> Operation { get; set; } = [];
}
