using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Course.Commands.EnrollCourse
{
    public class EnrollCourseCommandValidator : AbstractValidator<EnrollCourseCommand>
    {
        public EnrollCourseCommandValidator()
        {
            RuleFor(p => p.CourseId)
                .NotEmpty()
                .NotNull();
            RuleFor(p => p.UserId)
                .NotEmpty()
                .NotNull();
        }
    }
}
