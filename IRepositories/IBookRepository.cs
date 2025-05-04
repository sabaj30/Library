using IcenLibrary.Library.Models;
using System;

namespace IcenLibrary.IRepositories
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Delete(int id);
        Book[] GetAll(string procedureName);
        Book GetById(int id);
        Book[] Search(string procedureName, string text);
    }
}
