namespace FinGo.DataBase.Models;

public class Role
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public virtual ICollection<User> User { get; set; } = [];
}
