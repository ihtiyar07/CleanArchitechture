
public class TodoItem
{
    public Guid Id {get; set;} = new Guid();
    public required string Title  { get; set; }
    public bool IsCompleted {get; set;}
}