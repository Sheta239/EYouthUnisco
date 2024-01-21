using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class UserCourse
    {
        public int Id { get; set; }

        public Guid CourseId { get; set; }

        public Guid UserId { get; set; }
        public Guid PaymentOrderId { get; set; }

        public virtual Course Course { get; set; } = null!;

        public virtual User User { get; set; } = null!;
        public virtual PaymentOrder PaymentOrder { get; set; } = null!;
    }
}
