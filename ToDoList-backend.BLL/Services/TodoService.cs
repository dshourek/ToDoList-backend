using System.Collections.Generic;
using ToDoList_backend.BLL.Interfaces;
using ToDoList_backend.BLL.DTO;
using ToDoList_backend.DAL.Interfaces;
using ToDoList_backend.DAL.Repositories;
using System.Linq;
using ToDoList_backend.DAL.Models;

namespace ToDoList_backend.BLL.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IEnumerable<GetTodoDTO> GetAll() =>
            _todoRepository.GetAll().Select(i => new GetTodoDTO { Id = i.Id, Text = i.Text, Completed = i.Completed }).ToList();

        public GetTodoDTO Create(CreateTodoDTO model)
        {
            var todo = _todoRepository.Create(new CreateTodoModel { Text = model.Text });
            return new GetTodoDTO { Id = todo.Id, Text = todo.Text, Completed = todo.Completed };
        }

        public void Update(int id)
        {
            _todoRepository.Update(id);
        }

        public void Delete(int id)
        {
            _todoRepository.Delete(id);
        }
    }
}
