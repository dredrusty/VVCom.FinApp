using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class OperationDto : IDto<Operation>
{
    public int Id { get; set; }

    public decimal Sum { get; set; }

    public DateTime CreatedAt { get; set; }
}
