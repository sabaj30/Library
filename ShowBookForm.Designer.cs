namespace IceLibrary
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
            DataGridViewBook = new DataGridView();
            BtnUpdate = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            BtnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewBook).BeginInit();
            SuspendLayout();
            // 
            // DataGridViewBook
            // 
            DataGridViewBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewBook.BackgroundColor = Color.SteelBlue;
            DataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewBook.Columns.AddRange(new DataGridViewColumn[] { BtnUpdate });
            DataGridViewBook.Location = new Point(38, 108);
            DataGridViewBook.Name = "DataGridViewBook";
            DataGridViewBook.RowHeadersWidth = 51;
            DataGridViewBook.Size = new Size(727, 318);
            DataGridViewBook.TabIndex = 0;
            DataGridViewBook.CellContentClick += DataGridViewBook_CellContentClick;
            // 
            // BtnUpdate
            // 
            BtnUpdate.HeaderText = "Edit";
            BtnUpdate.MinimumWidth = 6;
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Text = "Choice";
            BtnUpdate.ToolTipText = "Choice";
            BtnUpdate.UseColumnTextForButtonValue = true;
            BtnUpdate.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(557, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 1;
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(422, 51);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(114, 30);
            BtnSearch.TabIndex = 2;
            BtnSearch.Text = "Search";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // ShowBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(821, 492);
            Controls.Add(BtnSearch);
            Controls.Add(textBox1);
            Controls.Add(DataGridViewBook);
            Name = "ShowBookForm";
            Text = "Books";
            Load += ShowBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridViewBook;
        private TextBox textBox1;
        private Button BtnSearch;
        private DataGridViewButtonColumn BtnUpdate;
    }
}