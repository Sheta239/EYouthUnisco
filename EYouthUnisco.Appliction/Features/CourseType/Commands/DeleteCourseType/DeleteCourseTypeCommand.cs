using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.DeleteCourseType
{
    public class DeleteCourseTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }

}
