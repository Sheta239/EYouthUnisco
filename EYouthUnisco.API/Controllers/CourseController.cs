using EYouthUnisco.Appliction.Features.Course.Commands.CreateCourse;
using EYouthUnisco.Appliction.Features.Course.Commands.DeleteCourse;
using EYouthUnisco.Appliction.Features.Course.Commands.UpdateCourse;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCourseDetails;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesByTag;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesByUser;
using EYouthUnisco.Appliction.Features.Course.Queries.GetCoursesList;
using EYouthUnisco.Domain;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EYouthUnisco.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class CourseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CourseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCourses")]
        public async Task<ActionResult<List<Course>>> GetAllCourses()
        {
            var dtos = await _mediator.Send(new GetCoursesListQuery());

            return Ok(dtos);
        }

        [HttpGet("{id}", Name = "GetCourseById")]
        public async Task<ActionResult<Course>> GetCourseById(Guid id)
        {
            var getEventDetailQuery = new GetCourseDetailsQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpGet("{id}", Name = "GetCoursesByTag")]
        public async Task<ActionResult<Course>> GetCoursesByTag(Guid TagId)
        {
            var getEventDetailQuery = new GetCoursesByTagQuery() { TagId = TagId };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpGet("{id}", Name = "GetCoursesByUser")]
        public async Task<ActionResult<Course>> GetCoursesByUser(Guid UserId)
        {
            var getEventDetailQuery = new GetCoursesByUserQuery() { UserId = UserId };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost(Name = "AddCourse")]
        [Authorize(Roles = "teacher")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCourseCommand createCourseCommand)
        {
            Guid id = await _mediator.Send(createCourseCommand);
            return Ok(id);
        }

        [HttpPut(Name = "UpdateCourse")]
        [Authorize(Roles = "teacher")]
        public async Task<ActionResult> Update([FromBody] UpdateCourseCommand updateCourseCommand)
        {
            await _mediator.Send(updateCourseCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCourse")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteCourseCommand = new DeleteCourseCommand() { Id = id };
            await _mediator.Send(deleteCourseCommand);
            return NoContent();
        }
        [HttpDelete("{id}", Name = "EnrollCourse")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> EnrollCourse(Guid UserId,Guid courseId)
        { 

        }

    }
}
