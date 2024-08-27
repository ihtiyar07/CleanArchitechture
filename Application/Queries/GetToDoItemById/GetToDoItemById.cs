public class GetToDoItemById:IGetTaskById
{
    private readonly ITaskRepository _taskRepository;

    public GetToDoItemById(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public TaskItem GetTask(int id)
    {
        return _taskRepository.GetTask(id);
    }
}

