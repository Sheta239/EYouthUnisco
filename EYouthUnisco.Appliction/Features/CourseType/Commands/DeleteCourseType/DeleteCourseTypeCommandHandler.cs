using MediatR;
using EYouthUnisco.Appliction.Contracts;
using System.Threading;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.DeleteCourseType
{
    public class DeleteCourseTypeCommandHandler : IRequestHandler<DeleteCourseTypeCommand>
    {
        private readonly ICourseTypeRepository _CourseTypeRepository;
        public DeleteCourseTypeCommandHandler(ICourseTypeRepository CourseTypeRepository)
        {
            _CourseTypeRepository = CourseTypeRepository;
        }

        public async Task<Unit> Handle(DeleteCourseTypeCommand request, CancellationToken cancellationToken)
        {
            var CourseType = await _CourseTypeRepository.GetByIdAsync(request.Id);

            await _CourseTypeRepository.DeleteAsync(CourseType);

            return Unit.Value;
        }
    }

}
