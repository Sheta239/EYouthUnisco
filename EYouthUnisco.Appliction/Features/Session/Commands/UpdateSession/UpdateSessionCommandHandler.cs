using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.Session.Commands.UpdateSession
{
    public class UpdateSessionCommandHandler : IRequestHandler<UpdateSessionCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.Session> _SessionRepository;
        private readonly IMapper _mapper;
        public UpdateSessionCommandHandler(IAsyncRepository<EYouthUnisco.Domain.Session> SessionRepository, IMapper mapper)
        {
            _SessionRepository = SessionRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateSessionCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.Session Session = _mapper.Map<EYouthUnisco.Domain.Session>(request);

            await _SessionRepository.UpdateAsync(Session);

            return Unit.Value;
        }
    }
}
