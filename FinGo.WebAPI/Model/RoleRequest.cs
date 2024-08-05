namespace FinGo.WebAPI.Model;

public class RoleRequest
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<UserRequest> Users { get; set; } = [];
}
