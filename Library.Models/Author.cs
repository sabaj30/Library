namespace IcenLibrary.Library.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<Book>? BookAuthor { get; set; }
    }
}
