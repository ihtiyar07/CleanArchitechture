public class TaskRepository : ITaskRepository
{
    private static readonly List<TaskItem> _tasks = new List<TaskItem>();

    static TaskRepository(){
        _tasks = new List<TaskItem>{
            new TaskItem(){Id=1, Title="Python", Description="Python ile proje yapılacak", IsCompleted=false},
            new TaskItem(){Id=2, Title="Ders", Description="Ortalama yükseltilecek", IsCompleted=true},
            new TaskItem(){Id=3, Title="Para", Description="Para kazanılacak", IsCompleted=false}

        };
    }
    
    public List<TaskItem> GetTasks()
    {
        return _tasks;
    } 
    public TaskItem GetTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        
        return task;
    }


    public void AddTask(TaskItem task)
    {
        _tasks.Add(task);
    }

    public void UpdateTask(TaskItem task)
    {
        var updateTask = _tasks.FirstOrDefault(t => t.Id == task.Id);
        if (updateTask != null)
        {
            updateTask.Title = task.Title;
            updateTask.Description = task.Description;
            updateTask.IsCompleted = task.IsCompleted;
        }
    }

    public TaskItem DeleteTask(int id)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            return null;
        }
        _tasks.Remove(task);
        return task;
    }

}
