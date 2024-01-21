using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.CreateTag
{
    public class CreateTagCommand : IRequest<Guid>
    {

        public string TagName { get; set; } = null!;

    }
}
