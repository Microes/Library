using Library.Application.Commands;
using Library.Application.Queries.Book;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var query = new GetBookQuery(id);
            var book = await _mediator.Send(query);
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddBookCommand command)
        {
            await _mediator.Send(command);
            return CreatedAtAction(nameof(Get), null);
        }
    }
}
