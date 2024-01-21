﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Domain
{
    public class Role
    {
        public Guid RoleId { get; set; }

        public string RoleName { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
