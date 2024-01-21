using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.Session.Commands.DeleteSession
{
    public class DeleteSessionCommand : IRequest
    {
        public Guid SessionId { get; set; }
    }

}
