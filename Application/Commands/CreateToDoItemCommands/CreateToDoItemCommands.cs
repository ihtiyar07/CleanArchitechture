public class CreateToDoItemCommands : IAddTask
{

    private readonly ITaskRepository _taskRepository;

    public CreateToDoItemCommands(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void AddTask(TaskItem task)
    {
        _taskRepository.AddTask(task);
    }
}