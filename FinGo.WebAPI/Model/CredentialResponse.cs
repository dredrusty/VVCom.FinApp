namespace FinGo.WebAPI.Model;

public class CredentialResponse
{
    public int Id { get; set; }

    public string Login { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
