using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("List")]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookService.GetAllBooks());
        }

        [HttpGet("GetBookById")]
        public IActionResult GetBookById(int bookId)
        {
            return Ok(_bookService.GetBookById(bookId));
        }

        

        [HttpPost("AddBook")]
        public IActionResult AddBook(BookEntity book)
        {
            _bookService.AddBook(book);
            return Ok();
        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int bookId)
        {
            _bookService.DeleteBook(bookId);
            return Ok();
        }

        [HttpPut("UpdateBook")]
        public IActionResult UpdateBook(BookEntity book)
        {
            _bookService.UpdateBook(book);
            return Ok();
        }

       
    }
}
