using IceLibrary.Contexts;
using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace IceLibrary.Repositories
{
    public class EFBookRepository : IBookRepository
    {
        private readonly LibraryContext BookContext;
        public EFBookRepository()
        {
            BookContext = new LibraryContext();
        }

        public void Add(Book book)
        {
            BookContext.Book.Add(book);
            BookContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var book = BookContext.Book.First(x => x.Id == id);
            BookContext.Book.Remove(book);
            BookContext.SaveChanges();
        }

        public List<Book> GetAll()
        {
            return BookContext.Book.ToList();
        }

        public Book GetById(int id)
        {
            return BookContext.Book.AsNoTracking().FirstOrDefault(x => x.Id == id)!;
        }

        public void Update(int id, Book book)
        {
            BookContext.Book.Update(book);
            BookContext.SaveChanges();
        }
    }
}
