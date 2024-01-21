using MediatR;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.UpdateCourseType
{
    public class UpdateCourseTypeCommand : IRequest
    {

        public string Name { get; set; } = null!;

    }
}
