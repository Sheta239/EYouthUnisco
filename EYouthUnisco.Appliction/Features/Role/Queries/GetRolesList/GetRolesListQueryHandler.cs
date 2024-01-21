using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRolesList
{
    public class GetRolesListQueryHandler : IRequestHandler<GetRolesListQuery, List<EYouthUnisco.Domain.Role>>
    {
        private readonly IRoleRepository _RoleRepository;
        private readonly IMapper _mapper;

        public GetRolesListQueryHandler(IRoleRepository RoleRepository, IMapper mapper)
        {
            _RoleRepository = RoleRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.Role>> Handle(GetRolesListQuery request, CancellationToken cancellationToken)
        {
            var allRoless = await _RoleRepository.GetAllRoleAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.Role>>(allRoless);
        }
    }
}
