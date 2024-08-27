public interface IGetTaskById
{
    TaskItem GetTask(int id);
}

public interface IGetAllTask
{
    List<TaskItem> GetTasks();

}

public interface IUpdateTask
{
    void UpdateTask(TaskItem task);
}

public interface IAddTask
{
    void AddTask(TaskItem task);
}
public interface IDeleteTask
{
    TaskItem DeleteTask(int id);
}