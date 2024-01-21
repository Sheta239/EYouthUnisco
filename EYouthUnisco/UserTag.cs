using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class UserTag
    {
        public int Id { get; set; }

        public Guid TagId { get; set; }

        public Guid UserId { get; set; }

        public virtual Tag Tag { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
