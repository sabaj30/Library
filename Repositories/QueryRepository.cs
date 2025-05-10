using IceLibrary.ConnectionString;
using IceLibrary.IRepositories;
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
        public DataTable GetAll(string procedureName)
        {
            var bookDT = new DataTable();
            var sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataReader bookReader;

            sqlConnection.Open();
            bookReader = sqlCommand.ExecuteReader();
            bookDT.Load(bookReader);
            sqlConnection.Close();

            return bookDT;
        }

        public DataTable GetById(string procedureName,int id)
        {
            var bookDT = new DataTable();
            var sqlCommand = new SqlCommand(procedureName, sqlConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.AddWithValue("@Id", id);
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

