using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Queries.GetTagsList
{
    public class GetTagsListQueryHandler : IRequestHandler<GetTagsListQuery, List<EYouthUnisco.Domain.Tag>>
    {
        private readonly ITagRepository _TagRepository;
        private readonly IMapper _mapper;

        public GetTagsListQueryHandler(ITagRepository TagRepository, IMapper mapper)
        {
            _TagRepository = TagRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.Tag>> Handle(GetTagsListQuery request, CancellationToken cancellationToken)
        {
            var allTagss = await _TagRepository.GetAllTagAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.Tag>>(allTagss);
        }
    }
}
