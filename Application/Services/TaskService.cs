using AutoMapper;

public class TaskService : ITaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public List<TaskItem> GetTasks()
    {
       return _taskRepository.GetTasks();
    }

    public void AddTask(TaskItem task)
    {
        _taskRepository.AddTask(task);
    }

    public void UpdateTask(TaskItem task)
    {
        _taskRepository.UpdateTask(task);
    }

    public TaskItem DeleteTask(int id)
    {
        var res = _taskRepository.DeleteTask(id);
        return res;
    }

    public TaskItem GetTask(int id)
    {
        return _taskRepository.GetTask(id);
    }
}
