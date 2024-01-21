using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.DeleteTag
{
    public class DeleteTagCommand : IRequest
    {
        public Guid Id { get; set; }
    }

}
