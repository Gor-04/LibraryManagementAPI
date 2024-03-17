using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UFAR.Classwork.Core.Services;
using UFAR.Classwork.Data.Entities;

namespace UFAR.Classwork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("List")]
        public IActionResult GetAllAuthors()
        {
            return Ok(_authorService.GetAllAuthors());
        }

        [HttpGet("GetAuthorById")]
        public IActionResult GetAuthorById(int authorId)
        {
            return Ok(_authorService.GetAuthorById(authorId));
        }

        [HttpPost("AddAuthor")]
        public IActionResult AddAuthor(AuthorEntity author)
        {
            _authorService.AddAuthor(author);
            return Ok();
        }

        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor(int authorId)
        {
            _authorService.DeleteAuthor(authorId);
            return Ok();
        }
    }
}
