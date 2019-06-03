using System.ComponentModel.DataAnnotations;

namespace ToDoList_backend.DAL.Models
{
    public class GetTodoModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public bool Completed { get; set; }
    }

    public class CreateTodoModel
    {
        [Required]
        public string Text { get; set; }
    }
    
}
