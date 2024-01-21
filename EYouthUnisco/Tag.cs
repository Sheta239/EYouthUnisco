using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class Tag
    {
        public Guid Id { get; set; }

        public string TagName { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();

    }
}
