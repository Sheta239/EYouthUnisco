using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRoleDetails
{
    public class GetRoleDetailsQueryHandler : IRequestHandler<GetRoleDetailsQuery, EYouthUnisco.Domain.Role>
    {
        private readonly IRoleRepository _RoleRepository;
        private readonly IMapper _mapper;

        public GetRoleDetailsQueryHandler(IRoleRepository RoleRepository, IMapper mapper)
        {
            _RoleRepository = RoleRepository;
            _mapper = mapper;
        }
        public async Task<EYouthUnisco.Domain.Role> Handle(GetRoleDetailsQuery request, CancellationToken cancellationToken)
        {
            var Role = await _RoleRepository.GetRoleByIdAsync(request.RoleId);

            return _mapper.Map<EYouthUnisco.Domain.Role>(Role);
        }
    }
}
