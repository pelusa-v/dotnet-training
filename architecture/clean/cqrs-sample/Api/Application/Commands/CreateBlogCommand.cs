using MediatR;

namespace Api;

public class CreateBlogCommand : IRequest<Blog>
{
    public string Title { get; set; }
    public string Content { get; set; }
}
