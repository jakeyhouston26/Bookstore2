using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bookstore2.Data;
using Bookstore2.Models;

namespace Bookstore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookstoreContext _context;

        public BooksController(BookstoreContext context)
        {
            _context = context;
        }

        // GET: api/books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/books/categories
        [HttpGet("categories")]
        public async Task<ActionResult<IEnumerable<string>>> GetCategories()
        {
            return await _context.Books
                .Select(b => b.Classification)
                .Distinct()
                .OrderBy(c => c)
                .ToListAsync();
        }

        // GET: api/books/category/{category}
        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByCategory(string category)
        {
            return await _context.Books
                .Where(b => b.Classification == category)
                .ToListAsync();
        }
    }
}
