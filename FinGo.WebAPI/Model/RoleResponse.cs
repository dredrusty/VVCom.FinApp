namespace FinGo.WebAPI.Model;

public class RoleResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<UserResponse> Users { get; set; } = [];
}
