using IcenLibrary.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcenLibrary.IRepositories
{
    public interface IAuthorRepository
    {
        void Add(Author book);
        void Delete(int id);
        Author[] GetAll(string procedureName);
        Author GetById(int id);
        Author[] Search(string procedureName, string text);
    }
}
