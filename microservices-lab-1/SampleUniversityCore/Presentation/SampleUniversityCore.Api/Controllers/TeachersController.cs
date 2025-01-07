using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleUniversityCore.Application.UsersFeatures.AddTeacher;

namespace SampleUniversityCore.Api;

[ApiController]
[Route("api/[controller]")]
public class TeachersController : ControllerBase
{
    private readonly IMediator _mediator;

    public TeachersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<AddTeacherDTO>> CreateTeacher([FromBody] AddTeacherCommand command, CancellationToken cancellationToken)
    {
        var res = await _mediator.Send(command, cancellationToken);
        return Ok(res);
    }
}
