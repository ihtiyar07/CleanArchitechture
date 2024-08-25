using System.ComponentModel.DataAnnotations;

public class TaskItem
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Burayı boş bırakamazsın !")]
    public string Title { get; set; } = null!;

    [Required]
    public string Description { get; set; } = null!;
    public bool IsCompleted { get; set; }
}
