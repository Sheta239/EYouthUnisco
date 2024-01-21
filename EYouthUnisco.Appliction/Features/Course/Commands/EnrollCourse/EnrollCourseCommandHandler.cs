using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Appliction.Features.Course.Commands.CreateCourse;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.EnrollCourse
{
    public class EnrollCourseCommandHandler : IRequestHandler<EnrollCourseCommand, Guid>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public EnrollCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(EnrollCourseCommand request, CancellationToken cancellationToken)
        {
            Domain.Course course = _mapper.Map<Domain.Course>(request);

            EnrollCourseCommandValidator validator = new EnrollCourseCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Course is not valid");
            }

            course = await _courseRepository.EnrollCourse(request.UserId,request.CourseId);

            return course.Id;
        }
    }
}
