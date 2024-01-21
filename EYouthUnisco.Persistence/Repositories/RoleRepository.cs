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
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(UniscoDbContext RoleDbContext) : base(RoleDbContext)
        {

        }

        public async Task<IReadOnlyList<Role>> GetAllRoleAsync()
        {
            List<Role> allRoles = new List<Role>();
            allRoles = await _dbContext.Roles.ToListAsync();
            return allRoles;
        }

        public async Task<Role> GetRoleByIdAsync(Guid id)
        {
            Role role = new Role();
            role = await _dbContext.Roles.FirstOrDefaultAsync(x => x.RoleId == id);
            return role;
        }

        public async Task<IReadOnlyList<Role>> GetRolesByUserIdAsync(Guid userId)
        {
            List<Role> userRoles = new List<Role>();
            userRoles = await _dbContext.Users.Where(x => x.UserId == userId).Select(r=>r.Role).ToListAsync();
            return userRoles;
        }
    }

}