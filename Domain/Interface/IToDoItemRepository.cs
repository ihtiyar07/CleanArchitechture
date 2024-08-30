public interface IToDoRepository
{
    Task<List<TodoItem>> GetTasks();
    void AddTask(TodoItem task);
    TodoItem UpdateTask(TodoItem task);
    Task<TodoItem> DeleteTask(Guid id);
    Task<TodoItem> GetTask(Guid id);
}
