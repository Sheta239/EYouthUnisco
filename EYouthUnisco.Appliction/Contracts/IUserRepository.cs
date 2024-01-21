using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Contracts
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<IReadOnlyList<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid id);
    }
}
