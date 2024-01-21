using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.DeleteCourse
{
    public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand>
    {
        private readonly ICourseRepository _CourseRepository;
        public DeleteCourseCommandHandler(ICourseRepository CourseRepository)
        {
            _CourseRepository = CourseRepository;
        }

        public async Task<Unit> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var Course = await _CourseRepository.GetByIdAsync(request.Id);

            await _CourseRepository.DeleteAsync(Course);

            return Unit.Value;
        }
    }

}
