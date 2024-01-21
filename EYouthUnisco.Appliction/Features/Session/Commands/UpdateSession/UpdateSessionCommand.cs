using MediatR;

namespace EYouthUnisco.Appliction.Features.Session.Commands.UpdateSession
{
    public class UpdateSessionCommand : IRequest
    {
        public Guid UserId { get; set; }

        public string Token { get; set; } = null!;

        public DateTime ExpirationDate { get; set; }
    }
}
