using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using System;
using System.Data;
using System.Linq;

namespace IceLibrary.Repositories
{
    public class EFRepository : IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll(string procedureName)
        {
            throw new NotImplementedException();
        }

        public DataTable GetById(string procedureName, int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string procedureName, string text)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Book book)
        {
            throw new NotImplementedException();
        }
    }
}
