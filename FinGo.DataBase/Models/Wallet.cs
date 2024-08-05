namespace FinGo.DataBase.Models;

public class Wallet
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<User> User { get; set; } = [];

    public virtual ICollection<Category> Category { get; set; } = [];
}
