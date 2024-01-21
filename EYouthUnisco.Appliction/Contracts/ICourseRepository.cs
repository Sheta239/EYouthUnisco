using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface ICourseRepository : IAsyncRepository<Course>
    {
        Task<IReadOnlyList<Course>> GetAllCoursesAsync();
        Task<IReadOnlyList<Course>> GetAllCoursesAsyncByUserId(Guid userid);
        Task<IReadOnlyList<Course>> GetAllCoursesAsyncByTagId(Guid tagId);
        Task<Course> GetCourseByIdAsync(Guid id);
    }
}
