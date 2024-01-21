using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Queries.GetCourseTypesList
{
    public class GetCourseTypesListQueryHandler : IRequestHandler<GetCourseTypesListQuery, List<EYouthUnisco.Domain.CourseType>>
    {
        private readonly ICourseTypeRepository _courseTypeRepository;
        private readonly IMapper _mapper;

        public GetCourseTypesListQueryHandler(ICourseTypeRepository courseTypeRepository, IMapper mapper)
        {
            _courseTypeRepository = courseTypeRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.CourseType>> Handle(GetCourseTypesListQuery request, CancellationToken cancellationToken)
        {
            var allCourseTypes = await _courseTypeRepository.GetAllCourseTypesAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.CourseType>>(allCourseTypes);
        }
    }
}
