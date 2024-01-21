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

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.CreateCourseType
{
    public class CreateCourseTypeCommandHandler : IRequestHandler<CreateCourseTypeCommand, Guid>
    {
        private readonly ICourseTypeRepository _courseTypeRepository;
        private readonly IMapper _mapper;

        public CreateCourseTypeCommandHandler(ICourseTypeRepository courseTypeRepository, IMapper mapper)
        {
            _courseTypeRepository = courseTypeRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateCourseTypeCommand request, CancellationToken cancellationToken)
        {
            Domain.CourseType courseType = _mapper.Map<Domain.CourseType>(request);

            CreateCourseTypeCommandValidator validator = new CreateCourseTypeCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Course Type is not valid");
            }

            courseType = await _courseTypeRepository.AddAsync(courseType);

            return courseType.Id;
        }
    }
}
