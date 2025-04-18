using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<Blog>> CreateBlog([FromBody] CreateBlogCommand command)
    {
        var blog = await _mediator.Send(command);
        return StatusCode(201, blog);
    }

    // [HttpGet("{id:int}")]
    // public async Task<ActionResult<Blog>> GetBlog(int id)
    // {
    //     var query = new GetBlogQuery { Id = id };
    //     var blog = await _mediator.Send(query);
    //     return blog is null ? NotFound() : Ok(blog);
    // }

    [HttpGet]
    public async Task<ActionResult<Blog>> ListBlogs()
    {
        var query = new ListBlogsQuery();
        var blogs = await _mediator.Send(query);
        return Ok(blogs);
    }
}