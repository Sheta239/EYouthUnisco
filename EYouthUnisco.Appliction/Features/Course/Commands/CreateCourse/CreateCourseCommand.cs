using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.CreateCourse
{
    public class CreateCourseCommand : IRequest<Guid>
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
