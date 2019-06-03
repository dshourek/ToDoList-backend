using System.ComponentModel.DataAnnotations;

namespace ToDoList_backend.BLL.DTO
{
    public class GetTodoDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public bool Completed { get; set; }
    }

    public class CreateTodoDTO
    {
        [Required]
        public string Text { get; set; }
    }
    
}
