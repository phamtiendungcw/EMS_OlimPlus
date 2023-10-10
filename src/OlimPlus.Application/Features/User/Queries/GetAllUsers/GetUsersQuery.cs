using MediatR;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.Features.User.Queries.GetAllUsers
{
    //public class GetUsersQuery : IRequest<List<UserDto>>
    //{
    //}

    public record GetUsersQuery : IRequest<List<UserDto>>;
}