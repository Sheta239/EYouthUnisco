using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.User.Queries.GetUsersList
{
    public class GetUsersListQueryHandler : IRequestHandler<GetUsersListQuery, List<EYouthUnisco.Domain.User>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public GetUsersListQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.User>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            var alluserss = await _userRepository.GetAllUsersAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.User>>(alluserss);
        }
    }
}
