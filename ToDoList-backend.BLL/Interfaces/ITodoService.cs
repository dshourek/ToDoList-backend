using System.Collections.Generic;
using ToDoList_backend.BLL.DTO;

namespace ToDoList_backend.BLL.Interfaces
{
    public interface ITodoService
    {
        IEnumerable<GetTodoDTO> GetAll();
        GetTodoDTO Create(CreateTodoDTO model);
        void Update(int id);
        void Delete(int id);
    }
}
