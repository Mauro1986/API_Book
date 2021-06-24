using API_Book.Models;
using API_Book.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookRepository _repo;
        public BooksController(BookRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("get-allbooks")]
        public IActionResult GetAllBooks()
        {
            var allbooks = _repo.GetAllBook().ToList();
            return Ok(allbooks);
        }
        [HttpPost("Add-book")]
        public IActionResult AddBook([FromBody]Book book)
        {
            _repo.AddBook(book);
            return Ok();
        }
        [HttpDelete("Delete-book")]
        public IActionResult DeleteBook(int id)
        {
            _repo.DeleteBook(id);
            return Ok();
        }
        [HttpPut("Update-book")]
        public IActionResult UpdateBook(int id,[FromBody] Book book)
        {
            _repo.UpdateBook(id, book);
            return Ok();
        }
    }
}
