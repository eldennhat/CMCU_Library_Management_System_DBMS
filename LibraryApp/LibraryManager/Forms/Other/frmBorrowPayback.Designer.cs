namespace LibraryManager.Forms.Other
{
    partial class frmBorrowPayback
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
            btnLoan = new Button();
            btnLoanDetails = new Button();
            SuspendLayout();
            // 
            // btnLoan
            // 
            btnLoan.Location = new Point(12, 12);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(288, 56);
            btnLoan.TabIndex = 4;
            btnLoan.Text = "Quản lý phiếu mượn";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnLoanDetails
            // 
            btnLoanDetails.Location = new Point(12, 74);
            btnLoanDetails.Name = "btnLoanDetails";
            btnLoanDetails.Size = new Size(288, 56);
            btnLoanDetails.TabIndex = 3;
            btnLoanDetails.Text = "Quản lý chi tiết phiếu mượn";
            btnLoanDetails.UseVisualStyleBackColor = true;
            btnLoanDetails.Click += btnLoanDetails_Click;
            // 
            // frmBorrowPayback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(312, 142);
            Controls.Add(btnLoan);
            Controls.Add(btnLoanDetails);
            Name = "frmBorrowPayback";
            Text = "Quản lý mượn/trả sách";
            FormClosing += frmBorrowPayback_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoan;
        private Button btnLoanDetails;
    }
}