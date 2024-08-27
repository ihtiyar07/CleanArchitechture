using Microsoft.AspNetCore.Mvc;

public class TaskController : Controller
{

    private readonly IGetTaskById _getTaskById;
    private readonly IGetAllTask _getAllTask;
    private readonly IUpdateTask _updateTask;
    private readonly IAddTask _addTask;
    private readonly IDeleteTask _deleteTask;


    public TaskController(
        IGetTaskById getTaskById,
        IGetAllTask getAllTask,
        IUpdateTask updateTask,
        IAddTask addTask,
        IDeleteTask deleteTask
    )
    {
        _getTaskById = getTaskById;
        _getAllTask = getAllTask;
        _updateTask = updateTask;
        _addTask = addTask;
        _deleteTask = deleteTask;
    }


    public IActionResult Index()
    {
        var tasks = _getAllTask.GetTasks();
        return View(tasks);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(TaskItem task)
    {
        if (ModelState.IsValid)
        {
            _addTask.AddTask(task);
            return RedirectToAction("Index");
        }

        return View(task);
    }


    public IActionResult Edit(int id)
    {
        var task = _getTaskById.GetTask(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }


    // POST: /Task/Edit
    [HttpPost]
    public IActionResult Edit(TaskItem task)
    {
        if (ModelState.IsValid)
        {
            _updateTask.UpdateTask(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }

    public IActionResult Delete(int id)
    {
        _deleteTask.DeleteTask(id);

        return RedirectToAction("Index");
    }
}
