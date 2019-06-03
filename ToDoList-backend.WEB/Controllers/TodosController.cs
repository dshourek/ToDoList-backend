using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoList_backend.BLL.DTO;
using ToDoList_backend.BLL.Interfaces;
using ToDoList_backend.WEB.Models;

namespace ToDoList_backend.WEB.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // GET api/todos
        [HttpGet]
        public ActionResult<IEnumerable<GetTodoViewModel>> Get()
        {
            try
            {
                IEnumerable<GetTodoViewModel> todos = _todoService.GetAll().Select(i =>
                    new GetTodoViewModel { Id = i.Id, Text = i.Text, Completed = i.Completed }).ToList();
                if (todos == null)
                {
                    return NotFound();
                }
                return Ok(todos);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // POST api/todos
        [HttpPost]
        public ActionResult<GetTodoViewModel> Post(CreateTodoViewModel model)
        {
            try
            {
                var dto = _todoService.Create(new CreateTodoDTO { Text = model.Text });
                var todo = new GetTodoViewModel { Id = dto.Id, Text = dto.Text, Completed = dto.Completed };
                return StatusCode(201, todo);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // PUT api/todos/1
        [HttpPut("{id}")]
        public ActionResult Put(int id)
        {
            try
            {
                _todoService.Update(id);
                return NoContent();
            }
            catch (NullReferenceException e)
            {
                return NotFound(e);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        // DELETE api/todos/1
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _todoService.Delete(id);
                return NoContent();
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}