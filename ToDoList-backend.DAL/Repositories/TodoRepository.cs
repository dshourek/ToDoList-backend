using System.Collections.Generic;
using System.Linq;
using ToDoList_backend.DAL.Interfaces;
using ToDoList_backend.DAL.Models;

namespace ToDoList_backend.DAL.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public List<GetTodoModel> GetAll() =>
            _todoContext.Set<TodoModel>().Select(i => new GetTodoModel { Id = i.Id, Text = i.Text, Completed = i.Completed }).ToList();

        public GetTodoModel Create(CreateTodoModel model)
        {
            TodoModel todo = new TodoModel { Text = model.Text, Completed = false };
            _todoContext.Set<TodoModel>().Add(todo);
            _todoContext.SaveChanges();
            return new GetTodoModel { Id = todo.Id, Text = todo.Text, Completed = todo.Completed };
        }

        public void Update(int id)
        {
            var todo = _todoContext.Set<TodoModel>().SingleOrDefault(i => i.Id == id);
            todo.Completed = !todo.Completed;
            _todoContext.SaveChanges();

        }
        public void Delete(int id)
        {
            _todoContext.TodoModels.Remove(_todoContext.Set<TodoModel>().SingleOrDefault(i => i.Id == id));
            _todoContext.SaveChanges();
        }
    }
}
