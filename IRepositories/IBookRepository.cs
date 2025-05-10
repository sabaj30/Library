using IceLibrary.Library.Models;

namespace IceLibrary.IRepositories
{
    public interface IBookRepository : IQueryRepository
    {
        void Add(Book book);
        void Delete(int id);
        void Update(int id,Book book);
    }
}
