namespace Managment.Forms
{
    partial class frmCreateLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateLoan));
            label1 = new Label();
            cbReader = new ComboBox();
            label2 = new Label();
            cbStaff = new ComboBox();
            label3 = new Label();
            cbBookCopy = new ComboBox();
            label4 = new Label();
            dtpLoanDate = new DateTimePicker();
            label5 = new Label();
            dtpDueDate = new DateTimePicker();
            label6 = new Label();
            txtNote = new TextBox();
            btnCreate = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Độc giả";
            // 
            // cbReader
            // 
            cbReader.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReader.FormattingEnabled = true;
            cbReader.Location = new Point(120, 17);
            cbReader.Name = "cbReader";
            cbReader.Size = new Size(250, 23);
            cbReader.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Nhân viên";
            // 
            // cbStaff
            // 
            cbStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStaff.FormattingEnabled = true;
            cbStaff.Location = new Point(120, 52);
            cbStaff.Name = "cbStaff";
            cbStaff.Size = new Size(250, 23);
            cbStaff.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 4;
            label3.Text = "Sách";
            // 
            // cbBookCopy
            // 
            cbBookCopy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBookCopy.FormattingEnabled = true;
            cbBookCopy.Location = new Point(120, 87);
            cbBookCopy.Name = "cbBookCopy";
            cbBookCopy.Size = new Size(250, 23);
            cbBookCopy.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 125);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Ngày mượn";
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Format = DateTimePickerFormat.Short;
            dtpLoanDate.Location = new Point(120, 122);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(150, 23);
            dtpLoanDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 160);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 8;
            label5.Text = "Ngày hẹn trả";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(120, 157);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(150, 23);
            dtpDueDate.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 195);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 10;
            label6.Text = "Ghi chú";
            // 
            // txtNote
            // 
            txtNote.BorderStyle = BorderStyle.FixedSingle;
            txtNote.Location = new Point(120, 192);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(250, 60);
            txtNote.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(120, 270);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 40);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Tạo phiếu";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(240, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCreateLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 330);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(txtNote);
            Controls.Add(label6);
            Controls.Add(dtpDueDate);
            Controls.Add(label5);
            Controls.Add(dtpLoanDate);
            Controls.Add(label4);
            Controls.Add(cbBookCopy);
            Controls.Add(label3);
            Controls.Add(cbStaff);
            Controls.Add(label2);
            Controls.Add(cbReader);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateLoan";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tạo phiếu mượn sách";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private ComboBox cbReader;
        private Label label2;
        private ComboBox cbStaff;
        private Label label3;
        private ComboBox cbBookCopy;
        private Label label4;
        private DateTimePicker dtpLoanDate;
        private Label label5;
        private DateTimePicker dtpDueDate;
        private Label label6;
        private TextBox txtNote;
        private Button btnCreate;
        private Button btnCancel;

        #endregion
    }
}