using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Commands.CreateSession
{
    public class CreateSessionCommand : IRequest<Guid>
    {

        public Guid UserId { get; set; }

        public string Token { get; set; } = null!;

        public DateTime ExpirationDate { get; set; }
    }
}
