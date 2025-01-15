using MediatR;
using Microsoft.AspNetCore.Mvc;
using SampleUniversityCore.Application.FeaturesCourses.SearchClasses;
using SampleUniversityCore.Application.Services.DTOs;

namespace SampleUniversityCore.Api;

[ApiController]
[Route("api/[controller]")]
public class CourseSectionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CourseSectionsController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("classes/search")]
    public async Task<ActionResult<List<CourseSectionDetailDTO>>> CreateCourseSection([FromBody] SearchClassesQuery query)
    {
        var result = await _mediator.Send(query);
        if (!result.IsSuccess)
        {
            return NotFound(result.Error);
        }

        return Ok(result.Value);
    }
}
