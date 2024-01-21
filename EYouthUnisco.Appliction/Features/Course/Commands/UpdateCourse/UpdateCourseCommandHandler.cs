using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.Course.Commands.UpdateCourse
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.Course> _CourseRepository;
        private readonly IMapper _mapper;
        public UpdateCourseCommandHandler(IAsyncRepository<EYouthUnisco.Domain.Course> CourseRepository, IMapper mapper)
        {
            _CourseRepository = CourseRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.Course Course = _mapper.Map<EYouthUnisco.Domain.Course>(request);

            await _CourseRepository.UpdateAsync(Course);

            return Unit.Value;
        }
    }
}
