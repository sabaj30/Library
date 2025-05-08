using IceLibrary.Library.Models;

namespace IceLibrary.IRepositories
{
    public interface IBookRepository : IQueryRepository
    {
        void Add(Book book);
        void Delete(int id);
        Book GetById(int id);
    }
}
