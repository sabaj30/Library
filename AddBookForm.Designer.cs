namespace IceLibrary
{
    partial class AddBookForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            TxtGenre = new TextBox();
            TxtTranslator = new TextBox();
            TxtPublisher = new TextBox();
            TxtBookName = new TextBox();
            lblGenre = new Label();
            lblTranslator = new Label();
            lblPublisher = new Label();
            lblBookName = new Label();
            groupBox3 = new GroupBox();
            BtnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 303);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtGenre);
            groupBox2.Controls.Add(TxtTranslator);
            groupBox2.Controls.Add(TxtPublisher);
            groupBox2.Controls.Add(TxtBookName);
            groupBox2.Controls.Add(lblGenre);
            groupBox2.Controls.Add(lblTranslator);
            groupBox2.Controls.Add(lblPublisher);
            groupBox2.Controls.Add(lblBookName);
            groupBox2.Location = new Point(366, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 213);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // TxtGenre
            // 
            TxtGenre.Location = new Point(96, 162);
            TxtGenre.Name = "TxtGenre";
            TxtGenre.Size = new Size(125, 27);
            TxtGenre.TabIndex = 7;
            // 
            // TxtTranslator
            // 
            TxtTranslator.Location = new Point(96, 119);
            TxtTranslator.Name = "TxtTranslator";
            TxtTranslator.Size = new Size(125, 27);
            TxtTranslator.TabIndex = 6;
            // 
            // TxtPublisher
            // 
            TxtPublisher.Location = new Point(96, 77);
            TxtPublisher.Name = "TxtPublisher";
            TxtPublisher.Size = new Size(125, 27);
            TxtPublisher.TabIndex = 5;
            // 
            // TxtBookName
            // 
            TxtBookName.Location = new Point(96, 32);
            TxtBookName.Name = "TxtBookName";
            TxtBookName.Size = new Size(125, 27);
            TxtBookName.TabIndex = 4;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(260, 162);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(48, 20);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "Genre";
            // 
            // lblTranslator
            // 
            lblTranslator.AutoSize = true;
            lblTranslator.Location = new Point(260, 119);
            lblTranslator.Name = "lblTranslator";
            lblTranslator.Size = new Size(74, 20);
            lblTranslator.TabIndex = 2;
            lblTranslator.Text = "Translator";
            // 
            // lblPublisher
            // 
            lblPublisher.AutoSize = true;
            lblPublisher.Location = new Point(260, 77);
            lblPublisher.Name = "lblPublisher";
            lblPublisher.Size = new Size(69, 20);
            lblPublisher.TabIndex = 1;
            lblPublisher.Text = "Publisher";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(260, 32);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(83, 20);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "BookName";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnSave);
            groupBox3.Location = new Point(12, 339);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(758, 86);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(6, 38);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 0;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 459);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "AddBookForm";
            Text = "AddBook";
            FormClosed += AddBookForm_FormClosed;
            Load += AddBookForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblGenre;
        private Label lblTranslator;
        private Label lblPublisher;
        private Label lblBookName;
        private TextBox TxtPublisher;
        private TextBox TxtBookName;
        private TextBox TxtGenre;
        private TextBox TxtTranslator;
        private GroupBox groupBox3;
        private Button BtnSave;
    }
}