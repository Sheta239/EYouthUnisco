using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Queries.GetTagDetails
{
    public class GetTagDetailsQuery : IRequest<EYouthUnisco.Domain.Tag>
    {
        public Guid Id { get; set; }
    }
}
