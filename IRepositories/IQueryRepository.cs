using IceLibrary.Library.Models;
using System.Data;

namespace IceLibrary.IRepositories
{
    public interface IQueryRepository
    {
        DataTable GetAll(string procedureName);
        DataTable Search(string procedureName, string text);
     
    }
}
