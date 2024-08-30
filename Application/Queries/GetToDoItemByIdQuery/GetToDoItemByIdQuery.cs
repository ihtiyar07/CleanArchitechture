using System.ComponentModel.DataAnnotations;
using MediatR;

namespace UpdatedToDoApp.Application.Queries.GettToDoItemByIdQuery{

    public class GettToDoByIdQuery : IRequest<TodoItem>{
    
    public Guid Id {get; set;}

    public GettToDoByIdQuery(Guid id)
    {
        Id = id;
    }

    }
}