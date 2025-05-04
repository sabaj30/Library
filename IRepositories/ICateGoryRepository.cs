using IcenLibrary.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcenLibrary.IRepositories
{
    public interface ICateGoryRepository
    {
        Category[] GetAll(string procedureName);
        Category[] Search(string procedureName, string text);
    }
}
