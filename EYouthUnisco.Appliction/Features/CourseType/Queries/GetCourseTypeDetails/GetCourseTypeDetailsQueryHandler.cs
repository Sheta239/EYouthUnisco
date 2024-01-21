using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Queries.GetCourseTypeDetails
{
    public class GetCourseTypeDetailsQueryHandler : IRequestHandler<GetCourseTypeDetailsQuery, EYouthUnisco.Domain.CourseType>
    {
        private readonly ICourseTypeRepository _courseTypeRepository;
        private readonly IMapper _mapper;

        public GetCourseTypeDetailsQueryHandler(ICourseTypeRepository courseTypeRepository, IMapper mapper)
        {
            _courseTypeRepository = courseTypeRepository;
            _mapper = mapper;
        }
        public async Task<EYouthUnisco.Domain.CourseType> Handle(GetCourseTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            var courseType = await _courseTypeRepository.GetCourseTypeByIdAsync(request.Id);

            return _mapper.Map<EYouthUnisco.Domain.CourseType>(courseType);
        }
    }
}
