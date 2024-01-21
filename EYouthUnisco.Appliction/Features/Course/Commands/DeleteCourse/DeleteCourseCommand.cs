using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.Course.Commands.DeleteCourse
{
    public class DeleteCourseCommand : IRequest
    {
        public Guid Id { get; set; }
    }

}
