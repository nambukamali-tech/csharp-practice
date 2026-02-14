namespace TodoList_API.Models
{
    public class TodoList
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public string TaskStatus { get; set; } = string.Empty;

    }
}
