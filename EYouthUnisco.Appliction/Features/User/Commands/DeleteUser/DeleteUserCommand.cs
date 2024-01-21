using MediatR;
using System;

namespace EYouthUnisco.Appliction.Features.User.Commands.DeleteUser
{
    public class DeleteUserCommand : IRequest
    {
        public Guid UserId { get; set; }
    }

}
