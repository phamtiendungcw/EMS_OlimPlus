using AutoMapper;
using MediatR;
using OlimPlus.Application.Contracts.Persistence;
using OlimPlus.Application.DTO.User;

namespace OlimPlus.Application.Features.User.Queries.GetAllUsers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, List<UserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<List<UserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            // Query the database
            var users = await _userRepository.GetAsync();

            // Convert data obj to DTO obj
            var data = _mapper.Map<List<UserDto>>(users);

            // Return list of DTO obj
            return data;
        }
    }
}