using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Library.Application.Commands
{
    public class AddBookCommand : IRequest
    {
        public Guid? Id { get; set; }

        public string Name { get; set; }
    }

    public class AddBookCommandHandler : IRequestHandler<AddBookCommand>
    {
        public Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
