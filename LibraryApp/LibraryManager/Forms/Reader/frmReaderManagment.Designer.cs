namespace LibraryManager.Forms.Reader
{
    partial class frmReaderManagment
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            depositDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerBindingSource = new BindingSource(components);
            txtFullNameReader = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPhoneNumberReader = new TextBox();
            label3 = new Label();
            txtAddressReader = new TextBox();
            label4 = new Label();
            txtFineReader = new TextBox();
            btnExportFile = new Button();
            btnDeleteAllReader = new Button();
            btnDeleteReader = new Button();
            btnEditReader = new Button();
            btnAddReader = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, createAtDataGridViewTextBoxColumn, fineDataGridViewTextBoxColumn, depositDataGridViewTextBoxColumn });
            dataGridView1.DataSource = readerBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(693, 450);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID người đọc";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 40;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Tên người đọc";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createAtDataGridViewTextBoxColumn
            // 
            createAtDataGridViewTextBoxColumn.DataPropertyName = "CreateAt";
            createAtDataGridViewTextBoxColumn.HeaderText = "Thời gian tạo";
            createAtDataGridViewTextBoxColumn.Name = "createAtDataGridViewTextBoxColumn";
            createAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            fineDataGridViewTextBoxColumn.DataPropertyName = "Fine";
            fineDataGridViewTextBoxColumn.HeaderText = "Tiền phạt";
            fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            fineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositDataGridViewTextBoxColumn
            // 
            depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
            depositDataGridViewTextBoxColumn.HeaderText = "Tiền cọc";
            depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
            depositDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(Models.Sub.Reader);
            // 
            // txtFullNameReader
            // 
            txtFullNameReader.BorderStyle = BorderStyle.FixedSingle;
            txtFullNameReader.Location = new Point(838, 33);
            txtFullNameReader.Name = "txtFullNameReader";
            txtFullNameReader.Size = new Size(151, 23);
            txtFullNameReader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(749, 37);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên người đọc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(749, 71);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại";
            // 
            // txtPhoneNumberReader
            // 
            txtPhoneNumberReader.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumberReader.Location = new Point(838, 67);
            txtPhoneNumberReader.Name = "txtPhoneNumberReader";
            txtPhoneNumberReader.Size = new Size(138, 23);
            txtPhoneNumberReader.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(782, 106);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 6;
            label3.Text = "Địa chỉ";
            // 
            // txtAddressReader
            // 
            txtAddressReader.BorderStyle = BorderStyle.FixedSingle;
            txtAddressReader.Location = new Point(838, 101);
            txtAddressReader.Name = "txtAddressReader";
            txtAddressReader.Size = new Size(174, 23);
            txtAddressReader.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(775, 139);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Tiền phạt";
            // 
            // txtFineReader
            // 
            txtFineReader.BorderStyle = BorderStyle.FixedSingle;
            txtFineReader.Location = new Point(838, 135);
            txtFineReader.Name = "txtFineReader";
            txtFineReader.Size = new Size(91, 23);
            txtFineReader.TabIndex = 7;
            // 
            // btnExportFile
            // 
            btnExportFile.Location = new Point(714, 248);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.Size = new Size(339, 23);
            btnExportFile.TabIndex = 25;
            btnExportFile.Text = "Xuất file excel";
            btnExportFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllReader
            // 
            btnDeleteAllReader.BackColor = Color.Red;
            btnDeleteAllReader.Location = new Point(984, 188);
            btnDeleteAllReader.Name = "btnDeleteAllReader";
            btnDeleteAllReader.Size = new Size(69, 32);
            btnDeleteAllReader.TabIndex = 24;
            btnDeleteAllReader.Text = "Xoá tất cả";
            btnDeleteAllReader.UseVisualStyleBackColor = false;
            btnDeleteAllReader.Click += btnDeleteAllReader_Click;
            // 
            // btnDeleteReader
            // 
            btnDeleteReader.Location = new Point(896, 188);
            btnDeleteReader.Name = "btnDeleteReader";
            btnDeleteReader.Size = new Size(58, 32);
            btnDeleteReader.TabIndex = 23;
            btnDeleteReader.Text = "Xoá";
            btnDeleteReader.UseVisualStyleBackColor = true;
            btnDeleteReader.Click += btnDeleteReader_Click;
            // 
            // btnEditReader
            // 
            btnEditReader.Location = new Point(802, 188);
            btnEditReader.Name = "btnEditReader";
            btnEditReader.Size = new Size(58, 32);
            btnEditReader.TabIndex = 22;
            btnEditReader.Text = "Sửa";
            btnEditReader.UseVisualStyleBackColor = true;
            btnEditReader.Click += btnEditReader_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.Location = new Point(714, 188);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(61, 32);
            btnAddReader.TabIndex = 21;
            btnAddReader.Text = "Thêm";
            btnAddReader.UseVisualStyleBackColor = true;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // frmReaderManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(btnExportFile);
            Controls.Add(btnDeleteAllReader);
            Controls.Add(btnDeleteReader);
            Controls.Add(btnEditReader);
            Controls.Add(btnAddReader);
            Controls.Add(label4);
            Controls.Add(txtFineReader);
            Controls.Add(label3);
            Controls.Add(txtAddressReader);
            Controls.Add(label2);
            Controls.Add(txtPhoneNumberReader);
            Controls.Add(label1);
            Controls.Add(txtFullNameReader);
            Controls.Add(dataGridView1);
            Name = "frmReaderManagment";
            Text = "Quản lý người đọc";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource readerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createAtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
        private TextBox txtFullNameReader;
        private Label label1;
        private Label label2;
        private TextBox txtPhoneNumberReader;
        private Label label3;
        private TextBox txtAddressReader;
        private Label label4;
        private TextBox txtFineReader;
        private Button btnExportFile;
        private Button btnDeleteAllReader;
        private Button btnDeleteReader;
        private Button btnEditReader;
        private Button btnAddReader;
    }
}