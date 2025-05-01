namespace IcenLibrary
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

        private void showBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBookForm showBookForm = new ShowBookForm();
            showBookForm.Show();
            
        }
    }
}
