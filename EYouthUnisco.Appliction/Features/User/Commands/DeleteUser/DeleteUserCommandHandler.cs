using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _UserRepository;
        public DeleteUserCommandHandler(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var User = await _UserRepository.GetByIdAsync(request.UserId);

            await _UserRepository.DeleteAsync(User);

            return Unit.Value;
        }
    }

}
