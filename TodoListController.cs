using Microsoft.AspNetCore.Mvc;
using TodoList_API.Services;
using TodoList_API.Models;

namespace TodoList_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly TodoServices _Service;
        public TodoListController(TodoServices services)
        {
            _Service = services;
        }
        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _Service.GetAllTasks();
            return Ok(tasks);
        }
        [HttpPost]
        public IActionResult CreateTask(TodoList task)
        {
            var createdTask = _Service.CreateTask(task);
            return CreatedAtAction(nameof(GetAllTasks),
                new { TaskId = createdTask.TaskId },
              createdTask);


        }
    }
}
