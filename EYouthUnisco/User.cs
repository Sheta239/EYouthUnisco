using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class User
    {
        public Guid UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? GoogleId { get; set; }

        public int RoleId { get; set; }

        public string? Mobile { get; set; }

        public bool? EmailValidation { get; set; }

        public bool? PhoneValidation { get; set; }

        public string? Bio { get; set; }

        public bool? Approved { get; set; }

        public bool? Verified { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
        public virtual ICollection<UserTag> UserTags { get; set; } = new List<UserTag>();
        public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();


    }
}
