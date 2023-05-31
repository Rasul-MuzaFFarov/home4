using Infrastructure.Service;
using Domain.Dtos;
using Microsoft.AspNetCore.Mvc;


namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]

public class TaskController : ControllerBase
{
    private TaskService _taskservice;

    public TaskController()
    {
        _taskservice = new TaskService();
    }
    [HttpGet("Task")]

    // public List<TaskDtos> GetTasks()
    // {
    //     return _taskservice.GetTasks(null,null,null);
    // }

    [HttpPost("AddTask")]
    public TaskDtos AddTask(TaskDtos task)
    {
        return _taskservice.AddTask(task);
    }

    [HttpPost("DeleteTask")]
     public TaskDtos DeleteTask(TaskDtos task)
    {
        return _taskservice.DeleteTask(task);
    }

    [HttpPost("StatusOfTask")]
     public TaskDtos StatusOfTask(TaskDtos task)
    {
        return _taskservice.StatusOfTask(task);
    }
}