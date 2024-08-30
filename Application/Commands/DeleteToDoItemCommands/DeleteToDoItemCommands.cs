using System.ComponentModel.DataAnnotations;
using MediatR;

namespace UpdatedToDoApp.Application.Commands.DeleteToDoItemCommands{

    public class DeleteToDoItem : IRequest<TodoItem>{
    
    public Guid Id {get; set;}

    public DeleteToDoItem(Guid id)
    {
        Id = id;
    }

    }
}