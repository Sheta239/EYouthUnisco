using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Commands.CreateSession
{
    public class CreateSessionCommandHandler : IRequestHandler<CreateSessionCommand, Guid>
    {
        private readonly ISessionRepository _SessionRepository;
        private readonly IMapper _mapper;

        public CreateSessionCommandHandler(ISessionRepository SessionRepository, IMapper mapper)
        {
            _SessionRepository = SessionRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateSessionCommand request, CancellationToken cancellationToken)
        {
            Domain.Session Session = _mapper.Map<Domain.Session>(request);

            CreateSessionCommandValidator validator = new CreateSessionCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Session is not valid");
            }

            Session = await _SessionRepository.AddAsync(Session);

            return Session.SessionId;
        }
    }
}
