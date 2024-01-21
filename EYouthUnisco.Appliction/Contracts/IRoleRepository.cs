using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface IRoleRepository : IAsyncRepository<Role>
    {
        Task<IReadOnlyList<Role>> GetAllRoleAsync();
        Task<Role> GetRoleByIdAsync(Guid id);
        Task<IReadOnlyList<Role>> GetRolesByUserIdAsync(Guid userId);
    }
}
