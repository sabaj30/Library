using IcenLibrary.ConnectionString;
using IcenLibrary.IRepositories;
using IcenLibrary.Library.Models;
using System.Data;
using System.Data.SqlClient;

namespace IcenLibrary.Repositories
{
    public class QueryRepository : IQueryRepository

    {
        protected readonly SqlConnection sqlConnection = null!;
        public QueryRepository()
        {
            sqlConnection = new SqlConnection(ConnectionStringDB.LibraryConnectionString);

        }
        public DataTable GetAll(string procedureName)
        {
            var bookDT = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader bookReader;

            sqlConnection.Open();
            bookReader = sqlCommand.ExecuteReader();
            bookDT.Load(bookReader);
            sqlConnection.Close();

            return bookDT;
        }

        public DataTable Search(string procedureName, string text)
        {
            var bookDT = new DataTable();
            SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@Text", text);
            SqlDataReader bookReader;

            sqlConnection.Open();
            bookReader = sqlCommand.ExecuteReader();
            bookDT.Load(bookReader);
            sqlConnection.Close();

            return bookDT;
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
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

