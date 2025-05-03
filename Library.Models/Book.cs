using Bogus;
using System;

namespace IcenLibrary.Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Publisher { get; set; }
        public string? Translator { get; set; }
        public int PageCount { get; set; }
        public string? Janer { get; set; }
        public ICollection<Author>? BookAuthor { get; set; }

    }

}

