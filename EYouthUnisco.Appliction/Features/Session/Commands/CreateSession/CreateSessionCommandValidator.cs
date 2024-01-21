using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Session.Commands.CreateSession
{
    public class CreateSessionCommandValidator : AbstractValidator<CreateSessionCommand>
    {
        public CreateSessionCommandValidator()
        {
            RuleFor(p => p.Token)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

        }
    }
}
