namespace TaskManager.API.Models;
using System;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; } = TaskStatus.Todo;
	public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime DueDate { get; set; }

    public int UserId { get; set; }
    public User User { get; set; } = new User();
}

public enum TaskStatus
{
    Todo,
    InProgress,
    Done
}
