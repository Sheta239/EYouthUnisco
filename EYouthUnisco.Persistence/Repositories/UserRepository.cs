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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(UniscoDbContext UserDbContext) : base(UserDbContext)
        {

        }

        public async Task<IReadOnlyList<User>> GetAllUsersAsync()
        {
            List<User> allUsers = new List<User>();
            allUsers = await _dbContext.Users.ToListAsync();
            return allUsers;
        }


        public async Task<User> GetUserByIdAsync(Guid id)
        {
            User user = new User();
            user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
            return user;
        }
    }

}
