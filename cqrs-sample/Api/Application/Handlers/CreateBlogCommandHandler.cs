using MediatR;

namespace Api;

public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, Blog>
{
    public async Task<Blog> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
    {
        return default;
    }
}
