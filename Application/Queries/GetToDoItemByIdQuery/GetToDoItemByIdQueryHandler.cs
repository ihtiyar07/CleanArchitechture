using System.Data.Common;
using MediatR;
using UpdatedToDoApp.Application.Queries.GettToDoItemByIdQuery;

namespace UpdatedToDoApp.Application.Queries.GetToDoItemByIdQueryHandler{
    public class GettAllToDoItemQueryHandler(IToDoRepository _repository) : IRequestHandler<GettToDoByIdQuery, TodoItem>
    {
        private readonly IToDoRepository repository = _repository;
        public Task<TodoItem> Handle(GettToDoByIdQuery request, CancellationToken cancellationToken)
        {
            Guid findId = request.Id;
            return repository.GetTask(findId);
        }
    }
}