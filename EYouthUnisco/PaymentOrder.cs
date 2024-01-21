using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class PaymentOrder
    {
        public Guid Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? PaymentDate { get; set; }

        public int StatusId { get; set; }

        public string Trn { get; set; } = null!;

        public int PaymentMethodId { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ICollection<UserCourse> UserCourses { get; set; } = new List<UserCourse>();
    }
}
