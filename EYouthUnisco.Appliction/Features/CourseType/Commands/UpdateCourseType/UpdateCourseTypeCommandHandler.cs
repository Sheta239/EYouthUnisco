using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EYouthUnisco.Domain;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.UpdateCourseType
{
    public class UpdateCourseTypeCommandHandler : IRequestHandler<UpdateCourseTypeCommand>
    {
        private readonly IAsyncRepository<EYouthUnisco.Domain.CourseType> _CourseTypeRepository;
        private readonly IMapper _mapper;
        public UpdateCourseTypeCommandHandler(IAsyncRepository<EYouthUnisco.Domain.CourseType> CourseTypeRepository, IMapper mapper)
        {
            _CourseTypeRepository = CourseTypeRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCourseTypeCommand request, CancellationToken cancellationToken)
        {
            EYouthUnisco.Domain.CourseType CourseType = _mapper.Map<EYouthUnisco.Domain.CourseType>(request);

            await _CourseTypeRepository.UpdateAsync(CourseType);

            return Unit.Value;
        }
    }
}
