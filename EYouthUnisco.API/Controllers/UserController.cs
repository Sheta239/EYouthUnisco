using EYouthUnisco.API.Enum;
using EYouthUnisco.API.Errors;
using EYouthUnisco.Appliction.Features.Role.Queries.GetRolesByUser;
using EYouthUnisco.Appliction.Features.User.Commands.CreateUser;
using EYouthUnisco.Appliction.Features.User.Commands.DeleteUser;
using EYouthUnisco.Appliction.Features.User.Commands.UpdateUser;
using EYouthUnisco.Appliction.Features.User.Queries.GetUserDetails;
using EYouthUnisco.Appliction.Features.User.Queries.GetUsersList;
using EYouthUnisco.Domain;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EYouthUnisco.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var dtos = await _mediator.Send(new GetUsersListQuery());
            if (dtos == null)
            {
                throw new ErrorUserNotFound();
            }
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetUserById")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            var getEventDetailQuery = new GetUserDetailsQuery() { UserId = id };
            if (getEventDetailQuery == null)
            {
                throw new ErrorUserNotFound();
            }
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpGet("{id}", Name = "GetRolesByUserId")]
        public async Task<ActionResult<User>> GetRolesByUserId(Guid UserId)
        {
            var getEventDetailQuery = new GetRolesByUserQuery() { UserId = UserId };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddUser")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateUserCommand createUserCommand)
        {
            Guid id = await _mediator.Send(createUserCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateUser")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
        {
            await _mediator.Send(updateUserCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteUser")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteUserCommand = new DeleteUserCommand() { UserId = id };
            await _mediator.Send(deleteUserCommand);
            return NoContent();
        }

    }
}
