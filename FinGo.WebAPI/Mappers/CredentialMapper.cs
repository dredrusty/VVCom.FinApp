using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public static class CredentialMapper
{
    public static CredentialDto ToDomain(this CredentialRequest credentialRequest)
    {
        var credentialDto = new CredentialDto();

        credentialDto.Id = credentialRequest.Id;

        credentialDto.Login = credentialRequest.Login;

        credentialDto.Password = credentialRequest.Password;

        return credentialDto;
    }

    public static CredentialRequest ToRequest(this CredentialDto credentialDto)
    {
        var credentialRequest = new CredentialRequest();

        credentialRequest.Id = credentialDto.Id;

        credentialRequest.Login = credentialDto.Login;

        credentialRequest.Password = credentialDto.Password;

        return credentialRequest;
    }

    public static CredentialDto ToDomain(this CredentialResponse credentialResponse)
    {
        var credentialDto = new CredentialDto();

        credentialDto.Id = credentialResponse.Id;

        credentialDto.Login = credentialResponse.Login;

        credentialDto.Password = credentialResponse.Password;

        return credentialDto;
    }

    public static CredentialResponse ToResponse(this CredentialDto credentialDto)
    {
        var credentialResponse = new CredentialResponse();

        credentialResponse.Id = credentialDto.Id;

        credentialResponse.Login = credentialDto.Login;

        credentialResponse.Password = credentialDto.Password;

        return credentialResponse;
    }
}
