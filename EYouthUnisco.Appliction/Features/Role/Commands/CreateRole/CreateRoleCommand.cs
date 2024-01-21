using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<Guid>
    {

        public string RoleName { get; set; } = null!;

    }
}
