using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Queries.GetCourseDetails
{
    public class GetCourseDetailsQuery : IRequest<EYouthUnisco.Domain.Course>
    {
        public Guid Id { get; set; }
    }
}
