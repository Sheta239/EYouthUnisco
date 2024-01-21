using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.CreateCourseType
{
    public class CreateCourseTypeCommand : IRequest<Guid>
    {
        public string Name { get; set; } = null!;

    }
}
