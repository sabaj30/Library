using IceLibrary.IRepositories;
using IceLibrary.Library.Models;
using IceLibrary.Repositories;

namespace IceLibrary
{
    public partial class UpdateBookForm : Form
    {
        protected readonly IBookRepository bookRepository;
        private readonly int id;
        public UpdateBookForm(int id)
        {
            bookRepository = new EFBookRepository();
            this.id = id;
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidateBook();
            var book = new Book()
            {
                Id = id,    
                Name = TxtBookName.Text,
                Publisher = TxtPublisher.Text,
                Translator = TxtTranslator.Text,
                Genre = TxtGenre.Text
            };
            bookRepository.Update(id , book);
            MessageBox.Show("Change");
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            var book = bookRepository.GetById(id);
            TxtBookName.Text = book.Name;
            TxtPublisher.Text = book.Publisher;
            TxtTranslator.Text = book.Translator;
            TxtGenre.Text = book.Genre;
        }

        private void ValidateBook()
        {
            if (string.IsNullOrEmpty(TxtBookName.Text))
                throw new Exception();
        }
    }
}
