using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using IceLibrary.Repositories;

namespace IceLibrary
{
    public partial class AddBookForm : Form
    {
        protected readonly IBookRepository bookAddRepository;
        public AddBookForm()
        {
            InitializeComponent();
            bookAddRepository = new BookRepository();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateBook();
            var book = new Book()
            {
                Name = TxtBookName.Text,
                Publisher = TxtPublisher.Text,
                Translator = TxtTranslator.Text,
                Janer = TxtGenre.Text
            };
            bookAddRepository.Add(book);

            MessageBox.Show("Book added successfully");

        }

        private void ValidateBook()
        {
            if (string.IsNullOrEmpty(TxtBookName.Text))
                throw new ArgumentNullException();

            if (TxtBookName.Text.Length > 32)
                throw new ArgumentOutOfRangeException();


        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void AddBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var showBook = new ShowBookForm();
            showBook.Show();
        }
    }
}
