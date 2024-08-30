using MediatR;
using UpdatedToDoApp.Application.Commands.UpdateToDoItemCommands;

namespace UpdatedToDoApp.Application.Commands.UpdateToDoItemCommandsHandler;

public class UpdateToDoItemCommandsHandler(IToDoRepository _repository) : IRequestHandler<UpdateToDoItem, TodoItem>
{
    private readonly IToDoRepository repository = _repository;

    public Task<TodoItem> Handle(UpdateToDoItem request, CancellationToken cancellationToken)
    {

        repository.GetTask(request.Id);
        
        var updateItem = new TodoItem
        {
            Id = request.Id,
            Title = request.Title,
            IsCompleted = request.IsCompleted
        };

        repository.UpdateTask(updateItem);

        return Task.FromResult(updateItem);

    }
}
