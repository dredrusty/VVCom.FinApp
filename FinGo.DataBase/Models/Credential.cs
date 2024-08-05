namespace FinGo.DataBase.Models;

public class Credential
{
    public int Id { get; set; }

    public string Login { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public virtual User User { get; set; } = null!;
}
