namespace Domain.Dtos;

public class TaskDtos
{
    public int Id { get; set; }
    public string TaskName { get; set; }
    public string Status { get; set; }
}

// public enum Status
// {
//    Todo = 1,
//    InProgress = 2,
//    Complete = 3,
// }