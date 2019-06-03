using System.ComponentModel.DataAnnotations;

namespace ToDoList_backend.DAL.Models
{
    public class TodoModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public bool Completed { get; set; }
    }
}
