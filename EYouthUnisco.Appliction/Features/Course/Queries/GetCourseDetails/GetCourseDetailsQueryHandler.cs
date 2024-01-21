using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Queries.GetCourseDetails
{
    public class GetCourseDetailsQueryHandler : IRequestHandler<GetCourseDetailsQuery, EYouthUnisco.Domain.Course>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetCourseDetailsQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<EYouthUnisco.Domain.Course> Handle(GetCourseDetailsQuery request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetCourseByIdAsync(request.Id);

            return _mapper.Map<EYouthUnisco.Domain.Course>(course);
        }
    }
}
