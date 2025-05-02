using IcenLibrary.IRepositories;
using IcenLibrary.Library.Models;
using System.Data.SqlClient;

namespace IcenLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        private const string ConnectionString = "data source=; initial catalog=IcenLibrary; integrated security=true;";
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

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("select * from Book", sqlConnection);
            SqlDataReader bookReader ;

            sqlConnection.Open();

            bookReader = sqlCommand.ExecuteReader();
            while(bookReader.Read())
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

        public Book[] Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}
