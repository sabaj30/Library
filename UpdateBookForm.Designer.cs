namespace IceLibrary
{
    partial class UpdateBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBookForm));
            groupBox3 = new GroupBox();
            BtnSave = new Button();
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
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnSave);
            groupBox3.Location = new Point(12, 384);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(185, 86);
            groupBox3.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(29, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(769, 275);
            groupBox1.TabIndex = 2;
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
            groupBox2.Location = new Point(373, 17);
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
            // UpdateBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(819, 482);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "UpdateBookForm";
            Text = "Update";
            Load += UpdateBookForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button BtnSave;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TxtGenre;
        private TextBox TxtTranslator;
        private TextBox TxtPublisher;
        private TextBox TxtBookName;
        private Label lblGenre;
        private Label lblTranslator;
        private Label lblPublisher;
        private Label lblBookName;
    }
}