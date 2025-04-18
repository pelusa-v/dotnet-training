using MediatR;

namespace Api;

public class ListBlogsQuery : IRequest<IEnumerable<Blog>>
{

}
