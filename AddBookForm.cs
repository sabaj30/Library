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
            bookAddRepository = new EFBookRepository();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateBook();
            var books = new Book()
            {
                Name = TxtBookName.Text,
                Publisher = TxtPublisher.Text,
                Translator = TxtTranslator.Text,
                Genre = TxtGenre.Text,

            };
            bookAddRepository.Add(books);

            MessageBox.Show("Book added successfully");
            this.Close();

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
