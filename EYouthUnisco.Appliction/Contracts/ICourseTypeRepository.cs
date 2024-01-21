using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface ICourseTypeRepository : IAsyncRepository<CourseType>
    {
        Task<IReadOnlyList<CourseType>> GetAllCourseTypesAsync();
        Task<CourseType> GetCourseTypeByIdAsync(Guid id);
    }
}
