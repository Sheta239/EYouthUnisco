using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRolesByUser
{
    public class GetRolesByUserQuery : IRequest<List<EYouthUnisco.Domain.Role>>
    {
        public Guid UserId { get; set; }
    }
}
