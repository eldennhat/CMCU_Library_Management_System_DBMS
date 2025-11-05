namespace LibraryManager.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnBookManagement = new Button();
            btnBorrowPayback = new Button();
            btnReaderMangment = new Button();
            btnStaffManagment = new Button();
            SuspendLayout();
            // 
            // btnBookManagement
            // 
            btnBookManagement.Location = new Point(12, 12);
            btnBookManagement.Name = "btnBookManagement";
            btnBookManagement.Size = new Size(384, 63);
            btnBookManagement.TabIndex = 4;
            btnBookManagement.Text = "Quản lý sách";
            btnBookManagement.UseVisualStyleBackColor = true;
            btnBookManagement.Click += btnBookManagement_Click;
            // 
            // btnBorrowPayback
            // 
            btnBorrowPayback.Location = new Point(15, 81);
            btnBorrowPayback.Name = "btnBorrowPayback";
            btnBorrowPayback.Size = new Size(384, 63);
            btnBorrowPayback.TabIndex = 5;
            btnBorrowPayback.Text = "Quản lý mượn/trả sách";
            btnBorrowPayback.UseVisualStyleBackColor = true;
            btnBorrowPayback.Click += btnBorrowPayback_Click;
            // 
            // btnReaderMangment
            // 
            btnReaderMangment.Location = new Point(12, 150);
            btnReaderMangment.Name = "btnReaderMangment";
            btnReaderMangment.Size = new Size(384, 63);
            btnReaderMangment.TabIndex = 6;
            btnReaderMangment.Text = "Quản lý độc giả";
            btnReaderMangment.UseVisualStyleBackColor = true;
            btnReaderMangment.Click += btnReaderMangment_Click;
            // 
            // btnStaffManagment
            // 
            btnStaffManagment.Location = new Point(12, 219);
            btnStaffManagment.Name = "btnStaffManagment";
            btnStaffManagment.Size = new Size(384, 63);
            btnStaffManagment.TabIndex = 7;
            btnStaffManagment.Text = "Quản lý nhân viên";
            btnStaffManagment.UseVisualStyleBackColor = true;
            btnStaffManagment.Click += btnStaffManagment_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(411, 296);
            Controls.Add(btnStaffManagment);
            Controls.Add(btnReaderMangment);
            Controls.Add(btnBorrowPayback);
            Controls.Add(btnBookManagement);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBookManagement;
        private Button btnBorrowPayback;
        private Button btnReaderMangment;
        private Button btnStaffManagment;
    }
}