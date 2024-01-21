using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Appliction.Features.User.Commands;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.CreateTag
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, Guid>
    {
        private readonly ITagRepository _TagRepository;
        private readonly IMapper _mapper;

        public CreateTagCommandHandler(ITagRepository TagRepository, IMapper mapper)
        {
            _TagRepository = TagRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            Domain.Tag Tag = _mapper.Map<Domain.Tag>(request);

            CreateTagCommandValidator validator = new CreateTagCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Tag is not valid");
            }

            Tag = await _TagRepository.AddAsync(Tag);

            return Tag.Id;
        }
    }
}
