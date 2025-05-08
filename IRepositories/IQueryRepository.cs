using IcenLibrary.Library.Models;
using System.Data;

namespace IcenLibrary.IRepositories
{
    public interface IQueryRepository
    {
        DataTable GetAll(string procedureName);
        DataTable Search(string procedureName, string text);
        void Add(Book book);
        void Delete(int id);
        Book GetById(int id);
    }
}
