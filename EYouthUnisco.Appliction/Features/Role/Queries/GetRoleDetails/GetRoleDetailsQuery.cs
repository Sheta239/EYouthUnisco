using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRoleDetails
{
    public class GetRoleDetailsQuery : IRequest<EYouthUnisco.Domain.Role>
    {
        public Guid RoleId { get; set; }
    }
}
