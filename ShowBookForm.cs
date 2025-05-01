using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IcenLibrary
{
    public partial class ShowBookForm : Form
    {
        public ShowBookForm()
        {
            InitializeComponent();
            FillDataGridViewBook();
        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowBookForm_Load(object sender, EventArgs e)
        {

        }

        private void FillDataGridViewBook()
        {
            Dictionary<int, string> Books = new Dictionary<int, string>()
            {
                [1]="the idiot",
                [2]="#C 10",
                [3]="Saba"

            };
            dataGridViewBook.DataSource = Books.ToArray();


        }
    }
}
