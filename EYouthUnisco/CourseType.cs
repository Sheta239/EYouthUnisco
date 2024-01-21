using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class CourseType
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    }
}
