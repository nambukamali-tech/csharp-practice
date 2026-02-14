using System.Collections.Generic;
using System.Linq;
using TodoList_API.Models;
namespace TodoList_API.Services
{
    public class TodoServices
    {
        private readonly List<TodoList> _tasks = new List<TodoList>();
        private int _nextTaskid = 1;

        //Get all tasks
        public List<TodoList> GetAllTasks() => _tasks;

        //Create task
        public TodoList CreateTask(TodoList task)
        {
            task.TaskId = _nextTaskid++;
            _tasks.Add(task);
            return task;
        }
    }
}
