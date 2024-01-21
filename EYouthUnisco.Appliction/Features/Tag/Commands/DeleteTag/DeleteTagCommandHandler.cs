using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.DeleteTag
{
    public class DeleteTagCommandHandler : IRequestHandler<DeleteTagCommand>
    {
        private readonly ITagRepository _TagRepository;
        public DeleteTagCommandHandler(ITagRepository TagRepository)
        {
            _TagRepository = TagRepository;
        }

        public async Task<Unit> Handle(DeleteTagCommand request, CancellationToken cancellationToken)
        {
            var Tag = await _TagRepository.GetByIdAsync(request.Id);

            await _TagRepository.DeleteAsync(Tag);

            return Unit.Value;
        }
    }

}
