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
    public class SessionRepository : BaseRepository<Session>, ISessionRepository
    {
        public SessionRepository(UniscoDbContext SessionDbContext) : base(SessionDbContext)
        {

        }

        public async Task<IReadOnlyList<Session>> GetAllSessionAsync()
        {
            List<Session> allSessions = new List<Session>();
            allSessions = await _dbContext.Sessions.ToListAsync();
            return allSessions;
        }

        public async Task<IReadOnlyList<Session>> GetSessionAsync(Guid userId)
        {
            List<Session> allSessions = new List<Session>();
            allSessions = await _dbContext.Sessions.Where(x => x.UserId == userId).ToListAsync();
            return allSessions;
        }
    }

}
