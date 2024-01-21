using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.UpdateTag
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.Tag> _TagRepository;
        private readonly IMapper _mapper;
        public UpdateTagCommandHandler(IAsyncRepository<EYouthUnisco.Domain.Tag> TagRepository, IMapper mapper)
        {
            _TagRepository = TagRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.Tag Tag = _mapper.Map<EYouthUnisco.Domain.Tag>(request);

            await _TagRepository.UpdateAsync(Tag);

            return Unit.Value;
        }
    }
}
