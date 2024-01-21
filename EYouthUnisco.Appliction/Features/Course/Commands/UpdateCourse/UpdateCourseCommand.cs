using MediatR;

namespace EYouthUnisco.Appliction.Features.Course.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IRequest
    {
        public string CourseName { get; set; }

        public bool? IsCanceled { get; set; }

        public Guid ExpertUser { get; set; }

        public int Duration { get; set; }

        public int TagId { get; set; }

        public string? Notes { get; set; }

        public int CourseType { get; set; }
    }
}
