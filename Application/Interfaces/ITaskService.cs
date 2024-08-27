public interface ITaskService
{
    List<TaskItem> GetTasks();
    TaskItem GetTask(int id);
    void AddTask(TaskItem task);
    void UpdateTask(TaskItem task);
    TaskItem DeleteTask(int id);
}
