using Microsoft.EntityFrameworkCore;

namespace ToDoList_backend.DAL.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<TodoModel> TodoModels { get; set; }
    }
}

