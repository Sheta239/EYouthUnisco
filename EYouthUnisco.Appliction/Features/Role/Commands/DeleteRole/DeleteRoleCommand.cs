using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.Role.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest
    {
        public Guid RoleId { get; set; }
    }

}
