using Bogus;
using System.ComponentModel.DataAnnotations;

namespace IceLibrary.Library.Models
{
    public class Book
    {
        public Book()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; } = null!;

        [StringLength(32)]
        public string? Publisher { get; set; }

        [StringLength(32)]
        public string? Translator { get; set; }
        public int? PageCount { get; set; } = 10;

        [StringLength(32)]
        public string? Genre { get; set; }
        public ICollection<BookAuthor>? BookAuthors { get; set; }

    }

}

