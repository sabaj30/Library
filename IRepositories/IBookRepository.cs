using IceLibrary.Library.Models;

namespace IceLibrary.IRepositories
{
    public interface IBookRepository 
    {
        List<Book>? GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Delete(int id);
        void Update(int id,Book book);
    }
}
