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

namespace EYouthUnisco.Appliction.Features.Role.Commands.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Guid>
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public CreateRoleCommandHandler(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            Domain.Role Role = _mapper.Map<Domain.Role>(request);

            CreateRoleCommandValidator validator = new CreateRoleCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Role is not valid");
            }

            Role = await _roleRepository.AddAsync(Role);

            return Role.RoleId;
        }
    }
}
