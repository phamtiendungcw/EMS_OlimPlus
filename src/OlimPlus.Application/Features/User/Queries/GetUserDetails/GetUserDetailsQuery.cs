using MediatR;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.Features.User.Queries.GetUserDetails
{
    public record GetUserDetailsQuery(int Id) : IRequest<UserDetailDto>;
}
