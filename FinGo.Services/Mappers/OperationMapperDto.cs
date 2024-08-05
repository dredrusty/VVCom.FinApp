using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class OperationDto : IDto<Operation>
{
    public Operation ToModel()
    {
        var operation = new Operation();

        operation.Id = Id;

        operation.Sum = Sum;

        operation.CreatedAt = CreatedAt;

        return operation;
    }

    public IDto<Operation> FromModel(Operation operation)
    {
        var operationDto = new OperationDto();

        operationDto.Id = operation.Id;

        operationDto.Sum = operation.Sum;

        operationDto.CreatedAt = operation.CreatedAt;

        return operationDto;
    }
}
