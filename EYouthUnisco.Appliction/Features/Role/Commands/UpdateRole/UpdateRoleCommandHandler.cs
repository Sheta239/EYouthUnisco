using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.Role.Commands.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.Role> _RoleRepository;
        private readonly IMapper _mapper;
        public UpdateRoleCommandHandler(IAsyncRepository<EYouthUnisco.Domain.Role> RoleRepository, IMapper mapper)
        {
            _RoleRepository = RoleRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.Role Role = _mapper.Map<EYouthUnisco.Domain.Role>(request);

            await _RoleRepository.UpdateAsync(Role);

            return Unit.Value;
        }
    }
}
