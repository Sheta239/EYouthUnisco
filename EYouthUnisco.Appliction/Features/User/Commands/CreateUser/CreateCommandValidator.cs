using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.User.Commands.CreateUser
{
    public class CreateCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Username)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

            RuleFor(p => p.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
        }
    }
}
