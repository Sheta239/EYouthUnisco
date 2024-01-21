using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Queries.GetTagsList
{
    public class GetTagsListQuery : IRequest<List<EYouthUnisco.Domain.Tag>>
    {

    }
}
