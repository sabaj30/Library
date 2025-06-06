﻿namespace IceLibrary
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ManageBookMenuStrip = new MenuStrip();
            booksManagementToolStripMenuItem = new ToolStripMenuItem();
            ShowBooksToolStripMenuItem = new ToolStripMenuItem();
            AddBooksToolStripMenuItem = new ToolStripMenuItem();
            ManageBookMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ManageBookMenuStrip
            // 
            ManageBookMenuStrip.ImageScalingSize = new Size(20, 20);
            ManageBookMenuStrip.Items.AddRange(new ToolStripItem[] { booksManagementToolStripMenuItem });
            ManageBookMenuStrip.Location = new Point(0, 0);
            ManageBookMenuStrip.Name = "ManageBookMenuStrip";
            ManageBookMenuStrip.Size = new Size(824, 28);
            ManageBookMenuStrip.TabIndex = 0;
            ManageBookMenuStrip.Text = "ManageBookMenuStrip";
            // 
            // booksManagementToolStripMenuItem
            // 
            booksManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ShowBooksToolStripMenuItem, AddBooksToolStripMenuItem });
            booksManagementToolStripMenuItem.Name = "booksManagementToolStripMenuItem";
            booksManagementToolStripMenuItem.Size = new Size(158, 24);
            booksManagementToolStripMenuItem.Text = "Book's Management";
            // 
            // ShowBooksToolStripMenuItem
            // 
            ShowBooksToolStripMenuItem.Name = "ShowBooksToolStripMenuItem";
            ShowBooksToolStripMenuItem.Size = new Size(224, 26);
            ShowBooksToolStripMenuItem.Text = "Show Books";
            ShowBooksToolStripMenuItem.Click += ShowBooksToolStripMenuItem_Click;
            // 
            // AddBooksToolStripMenuItem
            // 
            AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem";
            AddBooksToolStripMenuItem.Size = new Size(224, 26);
            AddBooksToolStripMenuItem.Text = "Add Books";
            AddBooksToolStripMenuItem.Click += AddBooksToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(824, 486);
            Controls.Add(ManageBookMenuStrip);
            MainMenuStrip = ManageBookMenuStrip;
            Name = "MainForm";
            Text = "Library";
            Load += MainForm_Load;
            ManageBookMenuStrip.ResumeLayout(false);
            ManageBookMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ManageBookMenuStrip;
        private ToolStripMenuItem booksManagementToolStripMenuItem;
        private ToolStripMenuItem ShowBooksToolStripMenuItem;
        private ToolStripMenuItem AddBooksToolStripMenuItem;
    }
}
