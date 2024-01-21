using EYouthUnisco.Appliction.Features.Payment.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EYouthUnisco.Appliction.Features.Role.Commands.CreateRole
{
    public class InitializePaymentCommandValidator : AbstractValidator<InitializePaymentCommand>
    {
        public InitializePaymentCommandValidator()
        {
            RuleFor(p => p.trn)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);
            RuleFor(p => p.userId)
               .NotEmpty()
               .NotNull();
            RuleFor(p => p.CourseId)
               .NotEmpty()
               .NotNull();

        }
    }
}
