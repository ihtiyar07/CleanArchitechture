public interface ITaskRepository
{
    List<TaskItem> GetTasks();
    void AddTask(TaskItem task);
    void UpdateTask(TaskItem task);
    void DeleteTask(int id);
    TaskItem GetTask(int? id);
}
