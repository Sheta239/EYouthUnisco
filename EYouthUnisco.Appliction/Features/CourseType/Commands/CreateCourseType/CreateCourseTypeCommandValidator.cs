using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.CourseType.Commands.CreateCourseType
{
    public class CreateCourseTypeCommandValidator : AbstractValidator<CreateCourseTypeCommand>
    {
        public CreateCourseTypeCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
        }
    }
}
