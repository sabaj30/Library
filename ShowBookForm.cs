using IcenLibrary.IRepositories;
using IcenLibrary.Repositories;
using System;

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
            var books = bookRepository.GetAll();
            dataGridViewBook.DataSource = books.ToArray();
        }
    }
}
