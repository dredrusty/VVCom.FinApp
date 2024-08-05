using FinGo.DataBase.Models;
using FinGo.Services.Mappers;

namespace FinGo.Services.Dto;

public partial class CredentialDto : IDto<Credential>
{
    public Credential ToModel()
    {
        var credential = new Credential();

        credential.Id = Id;

        credential.Login = Login;

        credential.Password = Password;

        return credential;
    }

    public IDto<Credential> FromModel(Credential credential)
    {
        var credeintialDto = new CredentialDto();

        credeintialDto.Id = credential.Id;

        credeintialDto.Login = credential.Login;

        credeintialDto.Password = credential.Password;

        return credeintialDto;
    }
}
