using System.Collections.Generic;
using ToDoList_backend.DAL.Models;

namespace ToDoList_backend.DAL.Interfaces
{
    public interface ITodoRepository
    {
        List<GetTodoModel> GetAll();
        GetTodoModel Create(CreateTodoModel model);
        void Update(int id);
        void Delete(int id);
    }
}
