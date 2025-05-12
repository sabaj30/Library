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
            bookRepository = new EFBookRepository();

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
            if (e.ColumnIndex == 1)
            {
                var dgv = ((DataGridView)sender).Rows[e.RowIndex].Cells["id"].Value.ToString();
                int id = Convert.ToInt32(dgv);
                bookRepository.Delete(id);
                MessageBox.Show("Removed");
                this.Close();

            }
        }

        private void ShowBookForm_Load(object sender, EventArgs e)
        {

        }
        private void FillDataGridViewBookFromDataBase()
        {
            var book = bookRepository.GetAll();
            DataGridViewBook.DataSource = book;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //var result = bookRepository.Search("Usp_Book_Search", textBox1.Text);
            //DataGridViewBook.DataSource = result;
        }


    }
}
