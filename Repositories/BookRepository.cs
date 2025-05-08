using System.Data.SqlClient;
using System.Data;
using IceLibrary.Library.Models;
using IceLibrary.Repositories;
using IceLibrary.IRepositories;

namespace IceLibrary.Repositories
{
    public class BookRepository : QueryRepository, IBookRepository
    {
        public void Add(Book book)
        {
            var sqlCommand = new SqlCommand("Usp_Book_Add", sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };

            sqlCommand.Parameters.AddWithValue("@Name", book.Name);
            sqlCommand.Parameters.AddWithValue("@Publisher", book.Publisher);
            sqlCommand.Parameters.AddWithValue("@Translator", book.Translator);
            sqlCommand.Parameters.AddWithValue("@Janer", book.Janer );

            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
