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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowBookForm));
            dataGridViewBook = new DataGridView();
            textBox1 = new TextBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewBook.BackgroundColor = Color.SteelBlue;
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Location = new Point(38, 108);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.RowHeadersWidth = 51;
            dataGridViewBook.Size = new Size(727, 318);
            dataGridViewBook.TabIndex = 0;
            dataGridViewBook.CellContentClick += dataGridViewBook_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(422, 51);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // ShowBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(821, 492);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewBook);
            Name = "ShowBookForm";
            Text = "Books";
            Load += ShowBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewBook;
        private TextBox textBox1;
        private Button btnSearch;
    }
}