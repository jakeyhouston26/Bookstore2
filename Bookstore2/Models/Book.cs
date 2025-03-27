using System.ComponentModel.DataAnnotations;

namespace Bookstore2.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public string Author { get; set; } = null!;

        [Required]
        public string Publisher { get; set; } = null!;

        [Required]
        public string ISBN { get; set; } = null!;

        [Required]
        public string Classification { get; set; } = null!;

        [Required]
        public int PageCount { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
