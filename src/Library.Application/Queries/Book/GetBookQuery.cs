using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Queries.Book
{
    public class GetBookQuery : IRequest<BookDTO>
    {
        public Guid Id { get; set; }

        public GetBookQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetBookQueryHandler : IRequestHandler<GetBookQuery, BookDTO>
    {
        public Task<BookDTO> Handle(GetBookQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
