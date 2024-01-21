using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Tag.Commands.CreateTag
{
    public class CreateTagCommandValidator : AbstractValidator<CreateTagCommand>
    {
        public CreateTagCommandValidator()
        {
            RuleFor(p => p.TagName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

        }
    }
}
