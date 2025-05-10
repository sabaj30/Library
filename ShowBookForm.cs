using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using IceLibrary.Repositories;

namespace IceLibrary
{
    public partial class ShowBookForm : Form
    {
        protected readonly IBookRepository bookRepository;

        public ShowBookForm()
        {
            bookRepository = new BookRepository();

            InitializeComponent();
            FillDataGridViewBookFromDataBase();
        }

        private void DataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var dgv = ((DataGridView)sender).Rows[e.RowIndex].Cells["id"].Value.ToString();
                int id = Convert.ToInt32(dgv);
                var updateForm = new UpdateBookForm(id);
                updateForm.Show();

            }
        }

        private void ShowBookForm_Load(object sender, EventArgs e)
        {

        }
        private void FillDataGridViewBookFromDataBase()
        {
            var books = bookRepository.GetAll("Usp_Book_GetAll");
            Book[] booksLibrary = MapToBook(books);
            DataGridViewBook.DataSource = booksLibrary;
        }

        private static Book[] MapToBook(System.Data.DataTable dataTableBook)
        {
            Book[] booksLibrary = new Book[50];
            int index = 0;

            foreach (var dataRow in dataTableBook.Select())
            {
                var book = new Book()
                {

                    Id = dataRow["Id"] != DBNull.Value ? Convert.ToInt32(dataRow["Id"]) : 0,
                    Name = dataRow["Name"].ToString()!,
                    Publisher = dataRow["Publisher"].ToString(),
                    Translator = dataRow["Translator"].ToString(),
                    PageCount = dataRow["PageCount"] != DBNull.Value ? Convert.ToInt32(dataRow["PageCount"]) : 0,
                    Genre = dataRow["Genre"].ToString()
                };
                booksLibrary[index] = book;
                index++;
            }
            return booksLibrary;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var result = bookRepository.Search("Usp_Book_Search", textBox1.Text);
            DataGridViewBook.DataSource = result;
        }


    }
}
