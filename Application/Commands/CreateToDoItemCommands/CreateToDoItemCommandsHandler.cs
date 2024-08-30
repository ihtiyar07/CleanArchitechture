
using MediatR;
using UpdatedToDoApp.Application.Commands.CreateTodoItem;

namespace UpdatedToDoApp.Application.Commands.CreateTodoItemHandler
{
    public class CreateTodoItemHandler(IToDoRepository _repository) : IRequestHandler<CreateToDoItem, TodoItem>
    {

        private readonly IToDoRepository repository = _repository;


        public Task<TodoItem> Handle(CreateToDoItem request, CancellationToken cancellationToken)
        {
        var newItem = new TodoItem
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            IsCompleted = request.IsCompleted
        };

        repository.AddTask(newItem);

        return Task.FromResult(newItem);
        }
    }
}