using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class Course
    {
        public Guid Id { get; set; }
        public string CourseName { get; set; }

        public bool? IsCanceled { get; set; }

        public Guid ExpertUser { get; set; }

        public int Duration { get; set; }

        public Guid TagId { get; set; }

        public string? Notes { get; set; }

        public int CourseType { get; set; }

        public virtual User ExpertUserNavigation { get; set; } = null!;

        public virtual CourseType CourseTypeNavigation { get; set; } = null!;

        public virtual Tag Tag { get; set; } = null!;
        public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();


    }
}
