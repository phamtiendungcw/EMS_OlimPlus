using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.Features.User.Queries.GetUserDetails
{
    public class GetUserDetailsQueryHandler : IRequestHandler<GetUserDetailsQuery, UserDetailDto>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUserDetailsQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDetailDto> Handle(GetUserDetailsQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            var data = _mapper.Map<UserDetailDto>(user);

            return data;
        }
    }
}