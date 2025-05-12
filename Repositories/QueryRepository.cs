using IceLibrary.ConnectionString;
using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using System.Data;
using System.Data.SqlClient;

namespace IceLibrary.Repositories
{
    public class QueryRepository : IQueryRepository

    {
        protected readonly SqlConnection sqlConnection = null!;
        public QueryRepository()
        {
            sqlConnection = new SqlConnection(ConnectionStringDB.LibraryConnectionString);

        }

        public DataTable Search(string procedureName, string text)
        {
            var bookDT = new DataTable();
            var sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@Text", text);
            SqlDataReader bookReader;

            sqlConnection.Open();
            bookReader = sqlCommand.ExecuteReader();
            bookDT.Load(bookReader);
            sqlConnection.Close();

            return bookDT;
        }

    }
}

