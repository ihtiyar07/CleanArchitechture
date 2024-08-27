public class DeleteToDoItemCommands: IDeleteTask
{
    private readonly ITaskRepository _taskRepository;

    public DeleteToDoItemCommands(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }
    public TaskItem DeleteTask(int id)
    {
        return _taskRepository.DeleteTask(id);
    }
}