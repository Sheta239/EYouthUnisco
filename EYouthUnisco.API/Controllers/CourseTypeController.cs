using EYouthUnisco.Appliction.Features.CourseType.Commands.CreateCourseType;
using EYouthUnisco.Appliction.Features.CourseType.Commands.DeleteCourseType;
using EYouthUnisco.Appliction.Features.CourseType.Commands.UpdateCourseType;
using EYouthUnisco.Appliction.Features.CourseType.Queries.GetCourseTypeDetails;
using EYouthUnisco.Appliction.Features.CourseType.Queries.GetCourseTypesList;
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

    public class CourseTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCourseTypes")]
        public async Task<ActionResult<List<CourseType>>> GetAllCourseTypes()
        {
            var dtos = await _mediator.Send(new GetCourseTypesListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetCourseTypeById")]
        public async Task<ActionResult<CourseType>> GetCourseTypeById(Guid id)
        {
            var getEventDetailQuery = new GetCourseTypeDetailsQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddCourseType")]
        [Authorize(Roles = "Admin")]

        public async Task<ActionResult<Guid>> Create([FromBody] CreateCourseTypeCommand createCourseTypeCommand)
        {
            Guid id = await _mediator.Send(createCourseTypeCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateCourseType")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Update([FromBody] UpdateCourseTypeCommand updateCourseTypeCommand)
        {
            await _mediator.Send(updateCourseTypeCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCourseType")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteCourseTypeCommand = new DeleteCourseTypeCommand() { Id = id };
            await _mediator.Send(deleteCourseTypeCommand);
            return NoContent();
        }

    }
}
