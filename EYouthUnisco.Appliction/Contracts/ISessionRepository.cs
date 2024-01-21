using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface ISessionRepository : IAsyncRepository<Session>
    {
        Task<IReadOnlyList<Session>> GetAllSessionAsync();
        Task<IReadOnlyList<Session>> GetSessionAsync(Guid userId);
    }
}
