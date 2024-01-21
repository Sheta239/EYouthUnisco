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
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(UniscoDbContext TagDbContext) : base(TagDbContext)
        {

        }

        public async Task<IReadOnlyList<Tag>> GetAllTagAsync()
        {
            List<Tag> allTags = new List<Tag>();
            allTags = await _dbContext.Tags.ToListAsync();
            return allTags;
        }

        public async Task<Tag> GetTgagByIdAsync(Guid id)
        {
            Tag tag = new Tag();
            tag = await _dbContext.Tags.FirstOrDefaultAsync(x => x.Id == id);
            return tag;
        }

        public async Task<IReadOnlyList<Tag>> GetUserTagsAsync(Guid userId)
        {
            List<Tag> userTags = new List<Tag>();
            userTags = await _dbContext.Tags.Where(x=> x.UserTags.Any(user=> user.UserId == userId)).ToListAsync();
            return userTags;
        }
    }

}
