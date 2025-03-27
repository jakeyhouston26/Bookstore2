using Microsoft.EntityFrameworkCore;
using Bookstore2.Models;

namespace Bookstore2.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; } = null!;
    }
}
