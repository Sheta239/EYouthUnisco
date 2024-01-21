using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.CreateCourse
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, Guid>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            Domain.Course course = _mapper.Map<Domain.Course>(request);

            CreateCourseCommandValidator validator = new CreateCourseCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Course is not valid");
            }

            course = await _courseRepository.AddAsync(course);

            return course.Id;
        }
    }
}
