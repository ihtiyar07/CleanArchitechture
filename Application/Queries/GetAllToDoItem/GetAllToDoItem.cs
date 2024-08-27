public class GetlAllToDoItem : IGetAllTask
{
    private readonly ITaskRepository _taskRepository;

    public GetlAllToDoItem(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public List<TaskItem> GetTasks()
    {
        return _taskRepository.GetTasks();
    }
}