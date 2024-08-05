using AutoMapper;
using FinGo.DataBase.Models;
using FinGo.Services.Dto;
using FinGo.WebAPI.Model;

namespace FinGo.WebAPI.Mappers;

public class APIMapper : Profile
{
    public APIMapper()
    {
        CreateMap<CategoryRequest, CategoryDto>().ReverseMap();

        CreateMap<CategoryResponse, CategoryDto>().ReverseMap();

        CreateMap<CommentRequest, CommentDto>().ReverseMap();

        CreateMap<CommentResponse, CommentDto>().ReverseMap();

        CreateMap<CredentialRequest, Credential>().ReverseMap();

        CreateMap<CredentialResponse, Credential>().ReverseMap();

        CreateMap<OperationRequest, Operation>().ReverseMap();

        CreateMap<OperationResponse, Operation>().ReverseMap();

        CreateMap<RoleRequest, Role>().ReverseMap();

        CreateMap<RoleResponse, Role>().ReverseMap();

        CreateMap<UserRequest, User>().ReverseMap();

        CreateMap<UserRequest, User>().ReverseMap();

        CreateMap<WalletRequest, Wallet>().ReverseMap();

        CreateMap<WalletResponse, Wallet>().ReverseMap();
    }
}
