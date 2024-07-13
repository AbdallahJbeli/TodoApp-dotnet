using TodoApp.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    // Remove UserId property
    public User User { get; set; }
}
