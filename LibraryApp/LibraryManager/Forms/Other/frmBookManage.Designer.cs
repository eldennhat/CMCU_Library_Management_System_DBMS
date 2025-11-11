namespace LibraryManager.Forms.Other
{
    partial class frmBookManage
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
            btnBookCopy = new Button();
            btnBook = new Button();
            SuspendLayout();
            // 
            // btnBookCopy
            // 
            btnBookCopy.Location = new Point(12, 74);
            btnBookCopy.Name = "btnBookCopy";
            btnBookCopy.Size = new Size(288, 56);
            btnBookCopy.TabIndex = 1;
            btnBookCopy.Text = "Quản lý bản sao sách";
            btnBookCopy.UseVisualStyleBackColor = true;
            btnBookCopy.Click += btnBookCopy_Click;
            // 
            // btnBook
            // 
            btnBook.Location = new Point(12, 12);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(288, 56);
            btnBook.TabIndex = 2;
            btnBook.Text = "Quản lý bản sách";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // frmBookManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(312, 142);
            Controls.Add(btnBook);
            Controls.Add(btnBookCopy);
            MaximizeBox = false;
            Name = "frmBookManage";
            Text = "Quản lý sách";
            FormClosing += frmBookManage_FormClosing;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBookCopy;
        private Button btnBook;
    }
}