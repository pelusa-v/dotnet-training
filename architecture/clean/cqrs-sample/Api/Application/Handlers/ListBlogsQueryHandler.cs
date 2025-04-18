using MediatR;

namespace Api;

public class ListBlogsQueryHandler : IRequestHandler<ListBlogsQuery, IEnumerable<Blog>>
{
    public async Task<IEnumerable<Blog>> Handle(ListBlogsQuery request, CancellationToken cancellationToken)
    {
        return default;
    }
}
