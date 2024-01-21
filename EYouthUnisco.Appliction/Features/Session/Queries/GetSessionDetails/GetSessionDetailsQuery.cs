using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Queries.GetSessionDetails
{
    public class GetSessionDetailsQuery : IRequest<EYouthUnisco.Domain.Session>
    {
        public Guid SessionId { get; set; }
        public Guid UserId { get; set; }
    }
}
