using System.Data.Common;
using MediatR;
using UpdatedToDoApp.Application.Queries.GettToDoItemByIdQuery;

namespace UpdatedToDoApp.Application.Commands.DeleteToDoItemCommands{
    public class DeleteToDoItemHandler(IToDoRepository _repository) : IRequestHandler<DeleteToDoItem, TodoItem>
    {
        private readonly IToDoRepository repository = _repository;
        public Task<TodoItem> Handle(DeleteToDoItem request, CancellationToken cancellationToken)
        {
            Guid findId = request.Id;
            return repository.DeleteTask(findId);
        }
    }
}



