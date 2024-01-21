using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.User> _UserRepository;
        private readonly IMapper _mapper;
        public UpdateUserCommandHandler(IAsyncRepository<EYouthUnisco.Domain.User> UserRepository, IMapper mapper)
        {
            _UserRepository = UserRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.User User = _mapper.Map<EYouthUnisco.Domain.User>(request);

            await _UserRepository.UpdateAsync(User);

            return Unit.Value;
        }
    }
}
