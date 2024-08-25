using Microsoft.AspNetCore.Mvc;

public class TaskController : Controller
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public IActionResult Index()
    {
        var tasks = _taskService.GetTasks();
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
            _taskService.AddTask(task);
            return RedirectToAction("Index");
        }

        return View(task);
    }


    public IActionResult Edit(int id)
    {
        var task = _taskService.GetTask(id);
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
            _taskService.UpdateTask(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }

    public IActionResult Delete(int id)
    {
        _taskService.DeleteTask(id);

        return RedirectToAction("Index");
    }
}
