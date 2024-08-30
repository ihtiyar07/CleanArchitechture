
namespace UpdatedToDoApp.Infrastructure.Repositories.ToDoItemRepository
{

public class ToDoItemRepository : IToDoRepository
{
    private static readonly List<TodoItem> _itemList = new List<TodoItem>();

    static ToDoItemRepository(){
        _itemList = new List<TodoItem>{
            new TodoItem(){Id=new Guid(), Title="Python", IsCompleted=false},
            new TodoItem(){Id=new Guid(), Title="Ders", IsCompleted=true},
            new TodoItem(){Id=new Guid(), Title="Para", IsCompleted=false}

        };
    }
    
    public  Task<List<TodoItem>> GetTasks()
    {
        return Task.FromResult(_itemList);
    } 
    public Task<TodoItem> GetTask(Guid id)
    {
        var task = _itemList.FirstOrDefault(t => t.Id == id);

        if(task == null){
            throw new Exception("Id is not found");
        }

        return Task.FromResult(task);
    }


    public void AddTask(TodoItem task)
    {
        _itemList.Add(task);
    }

    public TodoItem UpdateTask(TodoItem task)
    {
        var updateTask = _itemList.FirstOrDefault(t => t.Id == task.Id);
        if (updateTask != null)
        {
            updateTask.Title = task.Title;
            updateTask.IsCompleted = task.IsCompleted;
            return updateTask;
        }
        throw new Exception("task is not defined");
    }

    public Task<TodoItem> DeleteTask(Guid id)
    {
        var task = _itemList.FirstOrDefault(t => t.Id == id);
        if (task == null)
        {
            throw new Exception("Id is not found");
        }
        _itemList.Remove(task);
        return Task.FromResult(task);
    }


    }
}