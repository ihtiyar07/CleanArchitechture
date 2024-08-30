using System.ComponentModel.DataAnnotations;
using MediatR;

namespace UpdatedToDoApp.Application.Commands.UpdateToDoItemCommands{

    public class UpdateToDoItem : IRequest<TodoItem>{
    
    public Guid Id {get; set;}
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public UpdateToDoItem(TodoItem item)
    {
        Id = item.Id;
        Title = item.Title;
        IsCompleted = item.IsCompleted;
    }
    }
}