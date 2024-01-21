using MediatR;

namespace EYouthUnisco.Appliction.Features.Role.Commands.UpdateRole
{
    public class UpdateRoleCommand : IRequest
    {

        public string RoleName { get; set; } = null!;

    }
}
