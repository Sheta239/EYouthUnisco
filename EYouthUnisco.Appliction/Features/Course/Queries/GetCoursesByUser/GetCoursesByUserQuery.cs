using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesByUser
{
    public class GetCoursesByUserQuery : IRequest<List<EYouthUnisco.Domain.Course>>
    {
        public Guid UserId { get; set; }
    }
}
