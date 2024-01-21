using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Queries.GetRolesList
{
    public class GetRolesListQuery : IRequest<List<EYouthUnisco.Domain.Role>>
    {

    }
}
