using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private readonly ITaskService _taskService;

    public ApiController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("GetProducts")]
    public IActionResult GetProducts()
    {
        var products =  _taskService.GetTasks();
        return Ok(products);
    }

    [HttpGet("GetProduct/{id}")]
    public IActionResult GetProduct(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var product = _taskService.GetTask(id);
        
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost("Create")]
    public IActionResult Create(TaskItem task)
    {
        _taskService.AddTask(task);
        return Ok(task);
    }

    [HttpPost("Edit")]
    public IActionResult Edit(TaskItem task)
    {
        _taskService.UpdateTask(task);
        return Ok();
    }

    [HttpPost("Delete")]
    public IActionResult Delete(int id)
    {
        _taskService.DeleteTask(id);
        return Ok();
    }
}