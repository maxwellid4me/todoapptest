using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TodoApp.Contracts.V1;
using TodoApp.Contracts.V1.Requests;
using TodoApp.Contracts.V1.Responses;
using TodoApp.Domain;
using TodoApp.Service;

namespace TodoApp.Controllers.v1
{
    public class TodoController : Controller
    {
        private ITodoService _todoService;
        private IMapper _mapper;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpPost(AppRoutes.Item.Create)]
        public async Task<IActionResult> Create([FromBody] TodoItemRequest todoItemRequest)
        {
            var item = new TodoItem
            {
                Id = new Guid(),
                CreateDate = DateTime.Now,
                Name = todoItemRequest.Name,
                Completed = false
            };

            item = await _todoService.CreateAsync(item);

            if (item == null)
            {
                return BadRequest(new { error = "Invalid entry" });
            }

            return Ok(item);
        }
    }
}
