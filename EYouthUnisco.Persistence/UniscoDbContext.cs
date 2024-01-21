using EYouthUnisco.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Persistence
{
    public class UniscoDbContext : DbContext
    {
        public UniscoDbContext(DbContextOptions<UniscoDbContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserTag> UserTags { get; set; }
    }
}
