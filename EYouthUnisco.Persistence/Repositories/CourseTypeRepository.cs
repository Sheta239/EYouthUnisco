using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Persistence.Repositories
{
    internal class CourseTypeRepository : BaseRepository<CourseType>, ICourseTypeRepository
    {
        public CourseTypeRepository(UniscoDbContext CourseTypeDbContext) : base(CourseTypeDbContext)
        {

        }

        public async Task<IReadOnlyList<CourseType>> GetAllCourseTypesAsync()
        {
            List<CourseType> allCourseTypes = new List<CourseType>();
            allCourseTypes = await _dbContext.CourseTypes.ToListAsync();
            return allCourseTypes;
        }

        public async Task<CourseType> GetCourseTypeByIdAsync(Guid id)
        {
            CourseType CourseType = new CourseType();
            CourseType = await _dbContext.CourseTypes.FirstOrDefaultAsync(x => x.Id == id);
            return CourseType;
        }

    }
}
