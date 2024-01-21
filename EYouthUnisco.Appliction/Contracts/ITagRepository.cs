using EYouthUnisco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface ITagRepository : IAsyncRepository<Tag>
    {
        Task<IReadOnlyList<Tag>> GetAllTagAsync();
        Task<IReadOnlyList<Tag>> GetUserTagsAsync(Guid userId);
        Task<Tag> GetTgagByIdAsync(Guid id);
    }
}
