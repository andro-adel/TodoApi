namespace TodoApi.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public bool IsComplete { get; set; }
}
