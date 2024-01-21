using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
    {
        private readonly IRoleRepository _RoleRepository;
        public DeleteRoleCommandHandler(IRoleRepository RoleRepository)
        {
            _RoleRepository = RoleRepository;
        }

        public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var Role = await _RoleRepository.GetByIdAsync(request.RoleId);

            await _RoleRepository.DeleteAsync(Role);

            return Unit.Value;
        }
    }

}
