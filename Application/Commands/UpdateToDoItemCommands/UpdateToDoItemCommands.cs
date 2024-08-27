public class UpdateToDoItemCommands : IUpdateTask
{
    private readonly ITaskRepository _taskRepository;

    public UpdateToDoItemCommands(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void UpdateTask(TaskItem task)
    {
        _taskRepository.UpdateTask(task);
    }
}