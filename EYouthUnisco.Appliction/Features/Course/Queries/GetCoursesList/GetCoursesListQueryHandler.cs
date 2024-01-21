﻿using AutoMapper;
using EYouthUnisco.Appliction.Contracts;
using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesList
{
    public class GetCoursesListQueryHandler : IRequestHandler<GetCoursesListQuery, List<EYouthUnisco.Domain.Course>>
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public GetCoursesListQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public async Task<List<EYouthUnisco.Domain.Course>> Handle(GetCoursesListQuery request, CancellationToken cancellationToken)
        {
            var allCourses = await _courseRepository.GetAllCoursesAsync();
            return _mapper.Map<List<EYouthUnisco.Domain.Course>>(allCourses);
        }
    }
}
