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
    public class CourseRepository : BaseRepository<Course>, ICourseRepository
    {
        public CourseRepository(UniscoDbContext CourseDbContext) : base(CourseDbContext)
        {

        }
        public async Task<IReadOnlyList<Course>> GetAllCoursesAsync()
        {
            List<Course> allCourses = new List<Course>();
            allCourses = await _dbContext.Courses.ToListAsync();
            return allCourses;
        }

        public async Task<IReadOnlyList<Course>> GetAllCoursesAsyncByTagId(Guid tagId)
        {
            List<Course> allCourses = new List<Course>();
            allCourses = await _dbContext.Courses.Where(x=>x.TagId==tagId).ToListAsync();
            return allCourses;
        }

        public async Task<IReadOnlyList<Course>> GetAllCoursesAsyncByUserId(Guid userid)
        {
            List<Course> allCourses = new List<Course>();
            allCourses = await _dbContext.Courses
                .Where(x => x.UserCourses.Any(u=>u.UserId==userid))
                .ToListAsync();
            return allCourses;
        }

        public async Task<Course> GetCourseByIdAsync(Guid id)
        {
            Course course = new Course();
            course = await _dbContext.Courses.FirstOrDefaultAsync(x => x.Id == id);
            return course;
        }
    }
}
