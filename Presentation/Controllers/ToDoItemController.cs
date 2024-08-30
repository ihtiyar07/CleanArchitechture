using MediatR;
using Microsoft.AspNetCore.Mvc;
using UpdatedToDoApp.Application.Commands.CreateTodoItem;
using UpdatedToDoApp.Application.Commands.DeleteToDoItemCommands;
using UpdatedToDoApp.Application.Commands.UpdateToDoItemCommands;
using UpdatedToDoApp.Application.Queries.GettAllToDoItemQuery;
using UpdatedToDoApp.Application.Queries.GettToDoItemByIdQuery;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ToDoController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var query = new GettAllToDoQuery();
            var products = await _mediator.Send(query);
            return Ok(products);
        }


        [HttpGet("GetProdut")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var query = new GettToDoByIdQuery(id);
            var product = await _mediator.Send(query);
            return Ok(product);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(TodoItem item)
        {
            var query = new CreateToDoItem(item);
            var product = await _mediator.Send(query);
            return Ok(product);
        }


        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var query = new DeleteToDoItem(id);
            var product = await _mediator.Send(query);
            return Ok(product);
        }


        [HttpPost("Update")]
        public async Task<IActionResult> Update(TodoItem item)
        {
            var query = new UpdateToDoItem(item);
            var product = await _mediator.Send(query);
            return Ok(product);
        }

    }

}
