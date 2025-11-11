namespace LibraryManager.Forms.BookManage
{
    partial class frmBookCopyManagment
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
            copyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            storageNoteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookMoneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookCopyBindingSource = new BindingSource(components);
            label1 = new Label();
            txtBarCode = new TextBox();
            txtStorageNote = new TextBox();
            label2 = new Label();
            txtBookMoney = new TextBox();
            label3 = new Label();
            txtPublisher = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbStatus = new ComboBox();
            cbIDBook = new ComboBox();
            label6 = new Label();
            btnExportFile = new Button();
            btnDeleteAllBookCopy = new Button();
            btnDeleteBookCopy = new Button();
            btnEditBookCopy = new Button();
            btnAddBookCopy = new Button();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookCopyBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { copyIdDataGridViewTextBoxColumn, bookIdDataGridViewTextBoxColumn, barcodeDataGridViewTextBoxColumn, storageNoteDataGridViewTextBoxColumn, bookMoneyDataGridViewTextBoxColumn, publisherNameDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookCopyBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(563, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // copyIdDataGridViewTextBoxColumn
            // 
            copyIdDataGridViewTextBoxColumn.DataPropertyName = "CopyId";
            copyIdDataGridViewTextBoxColumn.HeaderText = "ID Bản sao";
            copyIdDataGridViewTextBoxColumn.Name = "copyIdDataGridViewTextBoxColumn";
            copyIdDataGridViewTextBoxColumn.ReadOnly = true;
            copyIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "ID Đầu sách";
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            bookIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            barcodeDataGridViewTextBoxColumn.HeaderText = "Mã vạch";
            barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storageNoteDataGridViewTextBoxColumn
            // 
            storageNoteDataGridViewTextBoxColumn.DataPropertyName = "StorageNote";
            storageNoteDataGridViewTextBoxColumn.HeaderText = "Kệ sách";
            storageNoteDataGridViewTextBoxColumn.Name = "storageNoteDataGridViewTextBoxColumn";
            storageNoteDataGridViewTextBoxColumn.ReadOnly = true;
            storageNoteDataGridViewTextBoxColumn.Width = 80;
            // 
            // bookMoneyDataGridViewTextBoxColumn
            // 
            bookMoneyDataGridViewTextBoxColumn.DataPropertyName = "BookMoney";
            bookMoneyDataGridViewTextBoxColumn.HeaderText = "Giá tiền";
            bookMoneyDataGridViewTextBoxColumn.Name = "bookMoneyDataGridViewTextBoxColumn";
            bookMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            bookMoneyDataGridViewTextBoxColumn.Width = 120;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            publisherNameDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            publisherNameDataGridViewTextBoxColumn.ReadOnly = true;
            publisherNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookCopyBindingSource
            // 
            bookCopyBindingSource.DataSource = typeof(Models.BookManage.BookCopy);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(622, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Mã vạch";
            // 
            // txtBarCode
            // 
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Location = new Point(680, 56);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(100, 23);
            txtBarCode.TabIndex = 2;
            // 
            // txtStorageNote
            // 
            txtStorageNote.BorderStyle = BorderStyle.FixedSingle;
            txtStorageNote.Location = new Point(680, 90);
            txtStorageNote.Name = "txtStorageNote";
            txtStorageNote.Size = new Size(86, 23);
            txtStorageNote.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Kệ sách";
            // 
            // txtBookMoney
            // 
            txtBookMoney.BorderStyle = BorderStyle.FixedSingle;
            txtBookMoney.Location = new Point(680, 124);
            txtBookMoney.Name = "txtBookMoney";
            txtBookMoney.Size = new Size(143, 23);
            txtBookMoney.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(627, 128);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Giá tiền";
            // 
            // txtPublisher
            // 
            txtPublisher.BorderStyle = BorderStyle.FixedSingle;
            txtPublisher.Location = new Point(680, 158);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(154, 23);
            txtPublisher.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 162);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 7;
            label4.Text = "Nhà xuất bản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(614, 194);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "Trạng thái";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(680, 191);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 23);
            cbStatus.TabIndex = 12;
            // 
            // cbIDBook
            // 
            cbIDBook.FormattingEnabled = true;
            cbIDBook.Items.AddRange(new object[] { "Lost", "Available", "OnLoan", "Damaged" });
            cbIDBook.Location = new Point(680, 22);
            cbIDBook.Name = "cbIDBook";
            cbIDBook.Size = new Size(177, 23);
            cbIDBook.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(605, 26);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 13;
            label6.Text = "ID Đầu sách";
            // 
            // btnExportFile
            // 
            btnExportFile.Location = new Point(584, 292);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.Size = new Size(339, 23);
            btnExportFile.TabIndex = 20;
            btnExportFile.Text = "Xuất file excel";
            btnExportFile.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAllBookCopy
            // 
            btnDeleteAllBookCopy.BackColor = Color.Red;
            btnDeleteAllBookCopy.Location = new Point(854, 232);
            btnDeleteAllBookCopy.Name = "btnDeleteAllBookCopy";
            btnDeleteAllBookCopy.Size = new Size(69, 32);
            btnDeleteAllBookCopy.TabIndex = 19;
            btnDeleteAllBookCopy.Text = "Xoá tất cả";
            btnDeleteAllBookCopy.UseVisualStyleBackColor = false;
            btnDeleteAllBookCopy.Click += btnDeleteAllBookCopy_Click;
            // 
            // btnDeleteBookCopy
            // 
            btnDeleteBookCopy.Location = new Point(766, 232);
            btnDeleteBookCopy.Name = "btnDeleteBookCopy";
            btnDeleteBookCopy.Size = new Size(58, 32);
            btnDeleteBookCopy.TabIndex = 18;
            btnDeleteBookCopy.Text = "Xoá";
            btnDeleteBookCopy.UseVisualStyleBackColor = true;
            btnDeleteBookCopy.Click += btnDeleteBookCopy_Click;
            // 
            // btnEditBookCopy
            // 
            btnEditBookCopy.Location = new Point(672, 232);
            btnEditBookCopy.Name = "btnEditBookCopy";
            btnEditBookCopy.Size = new Size(58, 32);
            btnEditBookCopy.TabIndex = 17;
            btnEditBookCopy.Text = "Sửa";
            btnEditBookCopy.UseVisualStyleBackColor = true;
            btnEditBookCopy.Click += btnEditBookCopy_Click;
            // 
            // btnAddBookCopy
            // 
            btnAddBookCopy.Location = new Point(584, 232);
            btnAddBookCopy.Name = "btnAddBookCopy";
            btnAddBookCopy.Size = new Size(61, 32);
            btnAddBookCopy.TabIndex = 16;
            btnAddBookCopy.Text = "Thêm";
            btnAddBookCopy.UseVisualStyleBackColor = true;
            btnAddBookCopy.Click += btnAddBookCopy_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(854, 67);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(69, 42);
            btnReload.TabIndex = 21;
            btnReload.Text = "RELOAD";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // frmBookCopyManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(938, 450);
            Controls.Add(btnReload);
            Controls.Add(btnExportFile);
            Controls.Add(btnDeleteAllBookCopy);
            Controls.Add(btnDeleteBookCopy);
            Controls.Add(btnEditBookCopy);
            Controls.Add(btnAddBookCopy);
            Controls.Add(cbIDBook);
            Controls.Add(label6);
            Controls.Add(cbStatus);
            Controls.Add(label5);
            Controls.Add(txtPublisher);
            Controls.Add(label4);
            Controls.Add(txtBookMoney);
            Controls.Add(label3);
            Controls.Add(txtStorageNote);
            Controls.Add(label2);
            Controls.Add(txtBarCode);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmBookCopyManagment";
            Text = "Quản lý bản sao sách";
            Load += frmBookCopyManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookCopyBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bookCopyBindingSource;
        private DataGridViewTextBoxColumn copyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageNoteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookMoneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private Label label1;
        private TextBox txtBarCode;
        private TextBox txtStorageNote;
        private Label label2;
        private TextBox txtBookMoney;
        private Label label3;
        private TextBox txtPublisher;
        private Label label4;
        private Label label5;
        private ComboBox cbStatus;
        private ComboBox cbIDBook;
        private Label label6;
        private Button btnExportFile;
        private Button btnDeleteAllBookCopy;
        private Button btnDeleteBookCopy;
        private Button btnEditBookCopy;
        private Button btnAddBookCopy;
        private Button btnReload;
    }
}