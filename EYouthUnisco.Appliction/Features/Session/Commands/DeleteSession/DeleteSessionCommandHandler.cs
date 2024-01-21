using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Commands.DeleteSession
{
    public class DeleteSessionCommandHandler : IRequestHandler<DeleteSessionCommand>
    {
        private readonly ISessionRepository _SessionRepository;
        public DeleteSessionCommandHandler(ISessionRepository SessionRepository)
        {
            _SessionRepository = SessionRepository;
        }

        public async Task<Unit> Handle(DeleteSessionCommand request, CancellationToken cancellationToken)
        {
            var Session = await _SessionRepository.GetByIdAsync(request.SessionId);

            await _SessionRepository.DeleteAsync(Session);

            return Unit.Value;
        }
    }

}
