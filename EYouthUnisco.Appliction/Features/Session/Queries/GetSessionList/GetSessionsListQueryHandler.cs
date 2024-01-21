using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Queries.GetSessionsList
{
    public class GetSessionsListQueryHandler : IRequestHandler<GetSessionsListQuery, List<EYouthUnisco.Domain.Session>>
    {
        private readonly ISessionRepository _SessionRepository;
        private readonly IMapper _mapper;

        public GetSessionsListQueryHandler(ISessionRepository SessionRepository, IMapper mapper)
        {
            _SessionRepository = SessionRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.Session>> Handle(GetSessionsListQuery request, CancellationToken cancellationToken)
        {
            var allSessionss = await _SessionRepository.GetAllSessionAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.Session>>(allSessionss);
        }
    }
}
