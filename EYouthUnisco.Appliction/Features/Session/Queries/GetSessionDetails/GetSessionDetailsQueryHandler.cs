using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Queries.GetSessionDetails
{
    public class GetSessionDetailsQueryHandler : IRequestHandler<GetSessionDetailsQuery, EYouthUnisco.Domain.Session>
    {
        private readonly ISessionRepository _SessionRepository;
        private readonly IMapper _mapper;

        public GetSessionDetailsQueryHandler(ISessionRepository SessionRepository, IMapper mapper)
        {
            _SessionRepository = SessionRepository;
            _mapper = mapper;
        }
        public async Task<EYouthUnisco.Domain.Session> Handle(GetSessionDetailsQuery request, CancellationToken cancellationToken)
        {
            var Session = await _SessionRepository.GetSessionAsync(request.UserId);

            return _mapper.Map<EYouthUnisco.Domain.Session>(Session);
        }
    }
}
