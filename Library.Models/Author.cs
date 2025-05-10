namespace IceLibrary.Library.Models
{
    public class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<BookAuthor>? BookAuthors { get; set; }
    }
}
