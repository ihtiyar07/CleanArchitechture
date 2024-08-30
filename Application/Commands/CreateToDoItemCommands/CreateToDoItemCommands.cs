using System.ComponentModel.DataAnnotations;
using MediatR;

namespace UpdatedToDoApp.Application.Commands.CreateTodoItem{

    public class CreateToDoItem : IRequest<TodoItem>{

    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public CreateToDoItem(TodoItem item)
    {
        Title = item.Title;
        IsCompleted = item.IsCompleted;
    }
    }
}