using EYouthUnisco.Appliction.Features.Tag.Commands.CreateTag;
using EYouthUnisco.Appliction.Features.Tag.Commands.DeleteTag;
using EYouthUnisco.Appliction.Features.Tag.Commands.UpdateTag;
using EYouthUnisco.Appliction.Features.Tag.Queries.GetTagDetails;
using EYouthUnisco.Appliction.Features.Tag.Queries.GetTagsList;
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
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllTags")]
        public async Task<ActionResult<List<Tag>>> GetAllTags()
        {
            var dtos = await _mediator.Send(new GetTagsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetTagById")]
        public async Task<ActionResult<Tag>> GetTagById(Guid id)
        {
            var getEventDetailQuery = new GetTagDetailsQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddTag")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateTagCommand createTagCommand)
        {
            Guid id = await _mediator.Send(createTagCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateTag")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Update([FromBody] UpdateTagCommand updateTagCommand)
        {
            await _mediator.Send(updateTagCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteTag")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteTagCommand = new DeleteTagCommand() { Id = id };
            await _mediator.Send(deleteTagCommand);
            return NoContent();
        }

    }
}
