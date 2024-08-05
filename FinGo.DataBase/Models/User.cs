namespace FinGo.DataBase.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public virtual Credential Credential { get; set; } = null!;

    public virtual ICollection<Role> Role { get; set; } = [];

    public virtual ICollection<Wallet> Wallet { get; set; } = [];

    public virtual ICollection<Operation> Operation { get; set; } = [];

    public virtual ICollection<Comment> Comment { get; set; } = [];
}
