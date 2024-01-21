using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.User.Queries.GetUserDetails
{
    public class GetUserDetailsQuery : IRequest<EYouthUnisco.Domain.User>
    {
        public Guid UserId { get; set; }
    }
}
