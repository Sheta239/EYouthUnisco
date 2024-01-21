using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Queries.GetTagDetails
{
    public class GetTagDetailsQueryHandler : IRequestHandler<GetTagDetailsQuery, EYouthUnisco.Domain.Tag>
    {
        private readonly ITagRepository _TagRepository;
        private readonly IMapper _mapper;

        public GetTagDetailsQueryHandler(ITagRepository TagRepository, IMapper mapper)
        {
            _TagRepository = TagRepository;
            _mapper = mapper;
        }
        public async Task<EYouthUnisco.Domain.Tag> Handle(GetTagDetailsQuery request, CancellationToken cancellationToken)
        {
            var Tag = await _TagRepository.GetTgagByIdAsync(request.Id);

            return _mapper.Map<EYouthUnisco.Domain.Tag>(Tag);
        }
    }
}
