using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.User.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public string FirstName { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? GoogleId { get; set; }

        public int RoleId { get; set; }

        public string? Mobile { get; set; }

        public bool? EmailValidation { get; set; }

        public bool? PhoneValidation { get; set; }

        public string? Bio { get; set; }

        public bool? Approved { get; set; }

        public bool? Verified { get; set; }

    }
}
