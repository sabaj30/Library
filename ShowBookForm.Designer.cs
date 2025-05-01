namespace IcenLibrary
{
    partial class ShowBookForm
    {
      
        private System.ComponentModel.IContainer components = null;

      
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridViewBook = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.BackgroundColor = Color.SteelBlue;
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Dock = DockStyle.Fill;
            dataGridViewBook.Location = new Point(0, 0);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(800, 450);
            dataGridViewBook.TabIndex = 0;
            dataGridViewBook.CellContentClick += dataGridViewBook_CellContentClick;
            // 
            // ShowBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBook);
            Name = "ShowBookForm";
            Text = "Books";
            Load += ShowBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBook;
    }
}