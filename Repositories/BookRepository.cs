using IcenLibrary.IRepositories;
using IcenLibrary.Library.Models;
using System.Data.SqlClient;
using IcenLibrary.ConnectionString;
using System.Data;

namespace IcenLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SqlConnection sqlConnection;
        public BookRepository()
        {
            sqlConnection = new SqlConnection(ConnectionStringDB.LibraryConnectionString);

        }
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book[] GetAll()
        {
            
            var books = new Book[1000];
            int index = 0;

            SqlCommand sqlCommand = new SqlCommand("Usp_Book_GetAll", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader bookReader;

            sqlConnection.Open();

            bookReader = sqlCommand.ExecuteReader();
            while (bookReader.Read())
            {
                var book = new Book
                {
                    Id = Convert.ToInt32(bookReader["Id"]),
                    Name = bookReader["Name"].ToString()!,
                    Publisher = bookReader["Publisher"].ToString(),
                    Translator = bookReader["Translator"].ToString(),
                    PageCount = Convert.ToInt32(bookReader["PageCount"]),
                    Janer = bookReader["Janer"].ToString()
                };
                books[index] = book;
                index++;
            }
            sqlConnection.Close();
            return books;
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Book[] Search(string text)
        {
            var books = new Book[1000];
            int index = 0;

            SqlCommand sqlCommand = new SqlCommand("Usp_Book_Search", sqlConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Text", text);
            SqlDataReader bookReader;

            sqlConnection.Open();

            bookReader = sqlCommand.ExecuteReader();
            while (bookReader.Read())
            {
                if (bookReader.HasRows) 
                {
                    var book = new Book
                    {
                        Id = Convert.ToInt32(bookReader["Id"]),
                        Name = bookReader["Name"].ToString()!,
                        Publisher = bookReader["Publisher"].ToString(),
                        Translator = bookReader["Translator"].ToString(),
                        PageCount = Convert.ToInt32(bookReader["PageCount"]),
                        Janer = bookReader["Janer"].ToString()
                    };
                    books[index] = book;
                    index++;
                }
                
            }
            sqlConnection.Close();
            return books;
        }
    }
}
