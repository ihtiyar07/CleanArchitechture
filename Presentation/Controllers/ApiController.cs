using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{   

    private readonly IGetTaskById _getTaskById;
    private readonly IGetAllTask _getAllTask;
    private readonly IUpdateTask _updateTask;
    private readonly IAddTask _addTask;
    private readonly IDeleteTask _deleteTask;

     public ApiController(
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


    [HttpGet("GetProducts")]
    public IActionResult GetProducts()
    {
        var products =  _getAllTask.GetTasks();
        return Ok(products);
    }

    [HttpGet("GetProduct/{id}")]
    public IActionResult GetProduct(int id)
    {
        var product = _getTaskById.GetTask(id);
        
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost("Create")]
    public IActionResult Create(TaskItem task)
    {
        _addTask.AddTask(task);
        return Ok(task);
    }

    [HttpPost("Edit")]
    public IActionResult Edit(TaskItem task)
    {
        _updateTask.UpdateTask(task);
        return Ok();
    }

    [HttpPost("Delete")]
    public IActionResult Delete(int id)
    {
        var res = _deleteTask.DeleteTask(id);    
        if(res == null){
            return NotFound($"ID:{id} not found.");
        }  
        return Ok(res.Title + "is deletd");
    }
}