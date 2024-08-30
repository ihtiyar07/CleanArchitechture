using MediatR;
using UpdatedToDoApp.Application.Queries.GettAllToDoItemQuery;

namespace UpdatedToDoApp.Application.Queries.GettAllToDoItemQueryHandler
{
    public class GettAllToDoItemQueryHandler(IToDoRepository _repository) : IRequestHandler<GettAllToDoQuery, List<TodoItem>>
    {

        private readonly IToDoRepository repository = _repository;

        public Task<List<TodoItem>> Handle(GettAllToDoQuery request, CancellationToken cancellationToken)
        {
            return repository.GetTasks();
        }

    }
}