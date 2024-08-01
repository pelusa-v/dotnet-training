using MediatR;

namespace Api;

public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, Blog>
{
    public async Task<Blog> Handle(GetBlogQuery request, CancellationToken cancellationToken)
    {
        return default;
    }
}
