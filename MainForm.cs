namespace IceLibrary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ShowBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var showBookForm = new ShowBookForm();
            showBookForm.Show();

        }

        private void AddBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm();
            addBookForm.Show();
        }
    }
}
