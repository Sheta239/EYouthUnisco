using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Persistence.Repositories
{
    public class UserCourseRepository : BaseRepository<Course>
    {
        public UserCourseRepository(UniscoDbContext dbContext) : base(dbContext)
        {
        }
    }
}
