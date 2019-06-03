using System.ComponentModel.DataAnnotations;

namespace ToDoList_backend.WEB.Models
{
    public class GetTodoViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public bool Completed { get; set; }
    }

    public class CreateTodoViewModel
    {
        [Required]
        public string Text { get; set; }
    }
    
}
