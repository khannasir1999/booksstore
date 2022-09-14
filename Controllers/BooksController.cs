using BooksStoreupdated.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksStoreupdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _booksRepository.GetAllBooksAsync();
            return Ok(books);
        }
    }
}
