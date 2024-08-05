using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class OperationMapper
{
    public static OperationDto ToDomain(this OperationRequest operationRequest)
    {
        var operationDto = new OperationDto();

        operationDto.Id = operationRequest.Id;

        operationDto.Sum = operationRequest.Sum;

        operationDto.CreatedAt = operationRequest.CreatedAt;

        return operationDto;
    }

    public static OperationRequest ToRequest(this OperationDto operationDto)
    {
        var operationRequest = new OperationRequest();

        operationRequest.Id = operationDto.Id;

        operationRequest.Sum = operationDto.Sum;

        operationRequest.CreatedAt = operationDto.CreatedAt;

        return operationRequest;
    }

    public static OperationDto ToDomain(this OperationResponse operationResponse)
    {
        var operationDto = new OperationDto();

        operationDto.Id = operationResponse.Id;

        operationDto.Sum = operationResponse.Sum;

        operationDto.CreatedAt = operationResponse.CreatedAt;

        return operationDto;
    }

    public static OperationResponse ToResponse(this OperationDto operationDto)
    {
        var operationResponse = new OperationResponse();

        operationResponse.Id = operationDto.Id;

        operationResponse.Sum = operationDto.Sum;

        operationResponse.CreatedAt = operationDto.CreatedAt;

        return operationResponse;
    }
}
