using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.EnrollCourse
{
    public class EnrollCourseCommand : IRequest<Guid>
    {
        public Guid CourseId { get; set; }

        public Guid UserId { get; set; }

    }
}
