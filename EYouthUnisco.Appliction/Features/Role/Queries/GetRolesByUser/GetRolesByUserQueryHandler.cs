using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRolesByUser
{
    public class GetRolesByUserQueryHandler : IRequestHandler<GetRolesByUserQuery, List<EYouthUnisco.Domain.Role>>
    {
        private readonly IRoleRepository _RoleRepository;
        private readonly IMapper _mapper;

        public GetRolesByUserQueryHandler(IRoleRepository RoleRepository, IMapper mapper)
        {
            _RoleRepository = RoleRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.Role>> Handle(GetRolesByUserQuery request, CancellationToken cancellationToken)
        {
            var allRoles = await _RoleRepository.GetRolesByUserIdAsync(request.UserId);
            return _mapper.Map<List<EYouthUnisco.Domain.Role>>(allRoles);
        }
    }
}
