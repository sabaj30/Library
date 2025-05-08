using IcenLibrary.IRepositories;
using IcenLibrary.Library.Models;
using IcenLibrary.Repositories;

namespace IcenLibrary
{
    public partial class ShowBookForm : Form
    {
        private readonly IBookRepository bookRepository;

        public ShowBookForm()
        {
            bookRepository = new BookRepository();

            InitializeComponent();
            FillDataGridViewBookFromDataBase();
        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowBookForm_Load(object sender, EventArgs e)
        {

        }
        private void FillDataGridViewBookFromDataBase()
        {
            var books = bookRepository.GetAll("Usp_Book_GetAll");
            Book[] booksLibrary = MapToBook(books);
            dataGridViewBook.DataSource = booksLibrary;
        }

        private static Book[] MapToBook(System.Data.DataTable dataTableBook)
        {
            Book[] booksLibrary = new Book[50];
            int index = 0;

            foreach (var dataRow in dataTableBook.Select())
            {
                var book = new Book()
                {
                    Id = Convert.ToInt32(dataRow["Id"]),
                    Name = dataRow["Name"].ToString()!,
                    Publisher = dataRow["Publisher"].ToString(),
                    Translator = dataRow["Translator"].ToString(),
                    PageCount = Convert.ToInt32(dataRow["PageCount"]),
                    Janer = dataRow["Janer"].ToString()
                };
                booksLibrary[index] = book;
                index++;
            }
            return booksLibrary;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = bookRepository.Search("Usp_Book_Search", textBox1.Text);
            dataGridViewBook.DataSource = result;
        }
    }
}
