using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.User.Queries.GetUsersList
{
    public class GetUsersListQuery : IRequest<List<EYouthUnisco.Domain.User>>
    {

    }
}
