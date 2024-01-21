using EYouthUnisco.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Queries.GetCourseTypesList
{
    public class GetCourseTypesListQuery : IRequest<List<EYouthUnisco.Domain.CourseType>>
    {

    }
}
