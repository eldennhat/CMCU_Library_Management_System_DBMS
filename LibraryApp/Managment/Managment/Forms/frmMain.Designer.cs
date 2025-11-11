namespace Managment.Forms
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabControl1 = new TabControl();
            tabPage_Book = new TabPage();
            btnRemove = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label5 = new Label();
            txtPublishYear = new TextBox();
            label4 = new Label();
            txtBookAuthor = new TextBox();
            label3 = new Label();
            txtCategory = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtISBN = new TextBox();
            dataGridViewBook = new DataGridView();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookAuthorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publishYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            tabPage_BookCopy = new TabPage();
            cbStatus = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            cbIDBook = new ComboBox();
            btnRemoveBookCopy = new Button();
            btnEditBookCopy = new Button();
            btnAddBookCopy = new Button();
            txtPublisher = new TextBox();
            txtBookMoney = new TextBox();
            txtStorageNote = new TextBox();
            txtBarCode = new TextBox();
            label10 = new Label();
            dataGridViewBookCopy = new DataGridView();
            copyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            barcodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            storageNoteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookMoneyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publisherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookCopyBindingSource = new BindingSource(components);
            tabPage_ReturnBorrow = new TabPage();
            dataGridViewLoan = new DataGridView();
            btnViewLoanDetails = new Button();
            btnCreateLoan = new Button();
            btnReturnBook = new Button();
            tabPage_Reader = new TabPage();
            dataGridViewReader = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createAtDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerBindingSource = new BindingSource(components);
            tabPage_StaffManagment = new TabPage();
            dataGridViewStaff = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            defaultEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffBindingSource = new BindingSource(components);
            loanBindingSource = new BindingSource(components);
            loanDetailIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookTitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            barcodeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            loanDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            copyIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            depositDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            readerPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loanNoteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            bookAuthorDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bookMoneyDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            publisherNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            isReturnedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isOverdueDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            daysOverdueDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalFineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            tabPage_BookCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookCopyBindingSource).BeginInit();
            tabPage_ReturnBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).BeginInit();
            tabPage_Reader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).BeginInit();
            tabPage_StaffManagment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_Book);
            tabControl1.Controls.Add(tabPage_BookCopy);
            tabControl1.Controls.Add(tabPage_ReturnBorrow);
            tabControl1.Controls.Add(tabPage_Reader);
            tabControl1.Controls.Add(tabPage_StaffManagment);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 498);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_Book
            // 
            tabPage_Book.Controls.Add(btnRemove);
            tabPage_Book.Controls.Add(btnEdit);
            tabPage_Book.Controls.Add(btnAdd);
            tabPage_Book.Controls.Add(label5);
            tabPage_Book.Controls.Add(txtPublishYear);
            tabPage_Book.Controls.Add(label4);
            tabPage_Book.Controls.Add(txtBookAuthor);
            tabPage_Book.Controls.Add(label3);
            tabPage_Book.Controls.Add(txtCategory);
            tabPage_Book.Controls.Add(label2);
            tabPage_Book.Controls.Add(txtTitle);
            tabPage_Book.Controls.Add(label1);
            tabPage_Book.Controls.Add(txtISBN);
            tabPage_Book.Controls.Add(dataGridViewBook);
            tabPage_Book.Location = new Point(4, 24);
            tabPage_Book.Name = "tabPage_Book";
            tabPage_Book.Padding = new Padding(3);
            tabPage_Book.Size = new Size(793, 470);
            tabPage_Book.TabIndex = 0;
            tabPage_Book.Text = "Quản lý sách";
            tabPage_Book.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(668, 220);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 46);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemoveBook_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(587, 220);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 46);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEditBook_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(506, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 46);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAddBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 170);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "Năm xuất bản";
            // 
            // txtPublishYear
            // 
            txtPublishYear.BorderStyle = BorderStyle.FixedSingle;
            txtPublishYear.Location = new Point(568, 166);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(64, 23);
            txtPublishYear.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 136);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Tên tác giả";
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtBookAuthor.Location = new Point(568, 132);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(157, 23);
            txtBookAuthor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 102);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Thể loại";
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(568, 98);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 68);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Tên sách";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(568, 64);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(116, 23);
            txtTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 34);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "MSTC Quốc tế";
            // 
            // txtISBN
            // 
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Location = new Point(568, 30);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(81, 23);
            txtISBN.TabIndex = 1;
            // 
            // dataGridViewBook
            // 
            dataGridViewBook.AllowUserToAddRows = false;
            dataGridViewBook.AllowUserToDeleteRows = false;
            dataGridViewBook.AllowUserToResizeColumns = false;
            dataGridViewBook.AllowUserToResizeRows = false;
            dataGridViewBook.AutoGenerateColumns = false;
            dataGridViewBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBook.Columns.AddRange(new DataGridViewColumn[] { bookIdDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, bookAuthorDataGridViewTextBoxColumn, publishYearDataGridViewTextBoxColumn });
            dataGridViewBook.DataSource = bookBindingSource;
            dataGridViewBook.Location = new Point(0, 0);
            dataGridViewBook.Name = "dataGridViewBook";
            dataGridViewBook.ReadOnly = true;
            dataGridViewBook.RowHeadersVisible = false;
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBook.Size = new Size(443, 470);
            dataGridViewBook.TabIndex = 0;
            dataGridViewBook.CellClick += dataGridViewBook_CellClick;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "ID Đầu sách";
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            bookIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn.HeaderText = "MSTC Quốc tế";
            iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            iSBNDataGridViewTextBoxColumn.Width = 80;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 120;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            categoryNameDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            bookAuthorDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            bookAuthorDataGridViewTextBoxColumn.Width = 90;
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
            publishYearDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản";
            publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            publishYearDataGridViewTextBoxColumn.ReadOnly = true;
            publishYearDataGridViewTextBoxColumn.Width = 40;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(LibraryManager.Models.BookModel.Book);
            // 
            // tabPage_BookCopy
            // 
            tabPage_BookCopy.Controls.Add(cbStatus);
            tabPage_BookCopy.Controls.Add(label11);
            tabPage_BookCopy.Controls.Add(label9);
            tabPage_BookCopy.Controls.Add(label8);
            tabPage_BookCopy.Controls.Add(label7);
            tabPage_BookCopy.Controls.Add(label6);
            tabPage_BookCopy.Controls.Add(cbIDBook);
            tabPage_BookCopy.Controls.Add(btnRemoveBookCopy);
            tabPage_BookCopy.Controls.Add(btnEditBookCopy);
            tabPage_BookCopy.Controls.Add(btnAddBookCopy);
            tabPage_BookCopy.Controls.Add(txtPublisher);
            tabPage_BookCopy.Controls.Add(txtBookMoney);
            tabPage_BookCopy.Controls.Add(txtStorageNote);
            tabPage_BookCopy.Controls.Add(txtBarCode);
            tabPage_BookCopy.Controls.Add(label10);
            tabPage_BookCopy.Controls.Add(dataGridViewBookCopy);
            tabPage_BookCopy.Location = new Point(4, 24);
            tabPage_BookCopy.Name = "tabPage_BookCopy";
            tabPage_BookCopy.Padding = new Padding(3);
            tabPage_BookCopy.Size = new Size(793, 470);
            tabPage_BookCopy.TabIndex = 1;
            tabPage_BookCopy.Text = "Quản lý bản sao sách";
            tabPage_BookCopy.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(567, 191);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(115, 23);
            cbStatus.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(498, 196);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 32;
            label11.Text = "Trạng thái";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(481, 161);
            label9.Name = "label9";
            label9.Size = new Size(77, 15);
            label9.TabIndex = 31;
            label9.Text = "Nhà xuất bản";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 127);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 30;
            label8.Text = "Tiền sách";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(514, 93);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 29;
            label7.Text = "Kệ sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(509, 59);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 28;
            label6.Text = "Mã vạch";
            // 
            // cbIDBook
            // 
            cbIDBook.FormattingEnabled = true;
            cbIDBook.Location = new Point(567, 21);
            cbIDBook.Name = "cbIDBook";
            cbIDBook.Size = new Size(143, 23);
            cbIDBook.TabIndex = 27;
            // 
            // btnRemoveBookCopy
            // 
            btnRemoveBookCopy.Location = new Point(674, 246);
            btnRemoveBookCopy.Name = "btnRemoveBookCopy";
            btnRemoveBookCopy.Size = new Size(75, 46);
            btnRemoveBookCopy.TabIndex = 26;
            btnRemoveBookCopy.Text = "Xoá";
            btnRemoveBookCopy.UseVisualStyleBackColor = true;
            btnRemoveBookCopy.Click += btnRemoveBookCopy_Click;
            // 
            // btnEditBookCopy
            // 
            btnEditBookCopy.Location = new Point(593, 246);
            btnEditBookCopy.Name = "btnEditBookCopy";
            btnEditBookCopy.Size = new Size(75, 46);
            btnEditBookCopy.TabIndex = 25;
            btnEditBookCopy.Text = "Sửa";
            btnEditBookCopy.UseVisualStyleBackColor = true;
            btnEditBookCopy.Click += btnEditBookCopy_Click;
            // 
            // btnAddBookCopy
            // 
            btnAddBookCopy.Location = new Point(512, 246);
            btnAddBookCopy.Name = "btnAddBookCopy";
            btnAddBookCopy.Size = new Size(75, 46);
            btnAddBookCopy.TabIndex = 24;
            btnAddBookCopy.Text = "Thêm";
            btnAddBookCopy.UseVisualStyleBackColor = true;
            btnAddBookCopy.Click += btnAddBookCopy_Click;
            // 
            // txtPublisher
            // 
            txtPublisher.BorderStyle = BorderStyle.FixedSingle;
            txtPublisher.Location = new Point(567, 157);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(154, 23);
            txtPublisher.TabIndex = 22;
            // 
            // txtBookMoney
            // 
            txtBookMoney.BorderStyle = BorderStyle.FixedSingle;
            txtBookMoney.Location = new Point(567, 123);
            txtBookMoney.Name = "txtBookMoney";
            txtBookMoney.Size = new Size(101, 23);
            txtBookMoney.TabIndex = 20;
            // 
            // txtStorageNote
            // 
            txtStorageNote.BorderStyle = BorderStyle.FixedSingle;
            txtStorageNote.Location = new Point(567, 89);
            txtStorageNote.Name = "txtStorageNote";
            txtStorageNote.Size = new Size(123, 23);
            txtStorageNote.TabIndex = 18;
            // 
            // txtBarCode
            // 
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Location = new Point(567, 55);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(85, 23);
            txtBarCode.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 25);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 15;
            label10.Text = "ID Đầu sách";
            // 
            // dataGridViewBookCopy
            // 
            dataGridViewBookCopy.AllowUserToAddRows = false;
            dataGridViewBookCopy.AllowUserToDeleteRows = false;
            dataGridViewBookCopy.AllowUserToResizeColumns = false;
            dataGridViewBookCopy.AllowUserToResizeRows = false;
            dataGridViewBookCopy.AutoGenerateColumns = false;
            dataGridViewBookCopy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookCopy.Columns.AddRange(new DataGridViewColumn[] { copyIdDataGridViewTextBoxColumn, bookIdDataGridViewTextBoxColumn1, barcodeDataGridViewTextBoxColumn, storageNoteDataGridViewTextBoxColumn, bookMoneyDataGridViewTextBoxColumn, publisherNameDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            dataGridViewBookCopy.DataSource = bookCopyBindingSource;
            dataGridViewBookCopy.Location = new Point(0, 0);
            dataGridViewBookCopy.Name = "dataGridViewBookCopy";
            dataGridViewBookCopy.ReadOnly = true;
            dataGridViewBookCopy.RowHeadersVisible = false;
            dataGridViewBookCopy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBookCopy.Size = new Size(463, 470);
            dataGridViewBookCopy.TabIndex = 0;
            // 
            // copyIdDataGridViewTextBoxColumn
            // 
            copyIdDataGridViewTextBoxColumn.DataPropertyName = "CopyId";
            copyIdDataGridViewTextBoxColumn.HeaderText = "ID Bản sao";
            copyIdDataGridViewTextBoxColumn.Name = "copyIdDataGridViewTextBoxColumn";
            copyIdDataGridViewTextBoxColumn.ReadOnly = true;
            copyIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // bookIdDataGridViewTextBoxColumn1
            // 
            bookIdDataGridViewTextBoxColumn1.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn1.HeaderText = "ID Đầu sách";
            bookIdDataGridViewTextBoxColumn1.Name = "bookIdDataGridViewTextBoxColumn1";
            bookIdDataGridViewTextBoxColumn1.ReadOnly = true;
            bookIdDataGridViewTextBoxColumn1.Width = 40;
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            barcodeDataGridViewTextBoxColumn.HeaderText = "Mã vạch";
            barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            barcodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // storageNoteDataGridViewTextBoxColumn
            // 
            storageNoteDataGridViewTextBoxColumn.DataPropertyName = "StorageNote";
            storageNoteDataGridViewTextBoxColumn.HeaderText = "Kệ sách";
            storageNoteDataGridViewTextBoxColumn.Name = "storageNoteDataGridViewTextBoxColumn";
            storageNoteDataGridViewTextBoxColumn.ReadOnly = true;
            storageNoteDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookMoneyDataGridViewTextBoxColumn
            // 
            bookMoneyDataGridViewTextBoxColumn.DataPropertyName = "BookMoney";
            bookMoneyDataGridViewTextBoxColumn.HeaderText = "Tiền sách";
            bookMoneyDataGridViewTextBoxColumn.Name = "bookMoneyDataGridViewTextBoxColumn";
            bookMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            bookMoneyDataGridViewTextBoxColumn.Width = 70;
            // 
            // publisherNameDataGridViewTextBoxColumn
            // 
            publisherNameDataGridViewTextBoxColumn.DataPropertyName = "PublisherName";
            publisherNameDataGridViewTextBoxColumn.HeaderText = "Nhà xuất bản";
            publisherNameDataGridViewTextBoxColumn.Name = "publisherNameDataGridViewTextBoxColumn";
            publisherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Trạng thái";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            statusDataGridViewTextBoxColumn.Width = 80;
            // 
            // bookCopyBindingSource
            // 
            bookCopyBindingSource.DataSource = typeof(LibraryManager.Models.BookModel.BookCopy);
            // 
            // tabPage_ReturnBorrow
            // 
            tabPage_ReturnBorrow.Controls.Add(dataGridViewLoan);
            tabPage_ReturnBorrow.Controls.Add(btnViewLoanDetails);
            tabPage_ReturnBorrow.Controls.Add(btnCreateLoan);
            tabPage_ReturnBorrow.Controls.Add(btnReturnBook);
            tabPage_ReturnBorrow.Location = new Point(4, 24);
            tabPage_ReturnBorrow.Name = "tabPage_ReturnBorrow";
            tabPage_ReturnBorrow.Padding = new Padding(3);
            tabPage_ReturnBorrow.Size = new Size(793, 470);
            tabPage_ReturnBorrow.TabIndex = 2;
            tabPage_ReturnBorrow.Text = "Quản lý mượn - trả sách";
            tabPage_ReturnBorrow.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLoan
            // 
            dataGridViewLoan.AllowUserToAddRows = false;
            dataGridViewLoan.AllowUserToDeleteRows = false;
            dataGridViewLoan.AllowUserToResizeColumns = false;
            dataGridViewLoan.AllowUserToResizeRows = false;
            dataGridViewLoan.AutoGenerateColumns = false;
            dataGridViewLoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLoan.Columns.AddRange(new DataGridViewColumn[] { loanDetailIdDataGridViewTextBoxColumn, loanIdDataGridViewTextBoxColumn, readerNameDataGridViewTextBoxColumn, bookTitleDataGridViewTextBoxColumn, barcodeDataGridViewTextBoxColumn1, loanDateDataGridViewTextBoxColumn, dueDateDataGridViewTextBoxColumn, returnedDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn1, fineDataGridViewTextBoxColumn, staffNameDataGridViewTextBoxColumn, copyIdDataGridViewTextBoxColumn1, depositDataGridViewTextBoxColumn, readerIdDataGridViewTextBoxColumn, readerPhoneDataGridViewTextBoxColumn, staffIdDataGridViewTextBoxColumn, loanNoteDataGridViewTextBoxColumn, bookIdDataGridViewTextBoxColumn2, bookAuthorDataGridViewTextBoxColumn1, iSBNDataGridViewTextBoxColumn1, bookMoneyDataGridViewTextBoxColumn1, publisherNameDataGridViewTextBoxColumn1, isReturnedDataGridViewCheckBoxColumn, isOverdueDataGridViewCheckBoxColumn, daysOverdueDataGridViewTextBoxColumn, totalFineDataGridViewTextBoxColumn });
            dataGridViewLoan.DataSource = loanBindingSource;
            dataGridViewLoan.Location = new Point(0, 0);
            dataGridViewLoan.Name = "dataGridViewLoan";
            dataGridViewLoan.ReadOnly = true;
            dataGridViewLoan.RowHeadersVisible = false;
            dataGridViewLoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLoan.Size = new Size(518, 470);
            dataGridViewLoan.TabIndex = 3;
            // 
            // btnViewLoanDetails
            // 
            btnViewLoanDetails.Location = new Point(623, 280);
            btnViewLoanDetails.Name = "btnViewLoanDetails";
            btnViewLoanDetails.Size = new Size(75, 42);
            btnViewLoanDetails.TabIndex = 2;
            btnViewLoanDetails.Text = "Xem chi tiết";
            btnViewLoanDetails.UseVisualStyleBackColor = true;
            btnViewLoanDetails.Click += btnViewLoanDetails_Click;
            // 
            // btnCreateLoan
            // 
            btnCreateLoan.Location = new Point(693, 176);
            btnCreateLoan.Name = "btnCreateLoan";
            btnCreateLoan.Size = new Size(75, 42);
            btnCreateLoan.TabIndex = 1;
            btnCreateLoan.Text = "Tạo phiếu mượn";
            btnCreateLoan.UseVisualStyleBackColor = true;
            btnCreateLoan.Click += btnCreateLoan_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(558, 176);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(75, 42);
            btnReturnBook.TabIndex = 0;
            btnReturnBook.Text = "Trả sách";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // tabPage_Reader
            // 
            tabPage_Reader.Controls.Add(dataGridViewReader);
            tabPage_Reader.Location = new Point(4, 24);
            tabPage_Reader.Name = "tabPage_Reader";
            tabPage_Reader.Padding = new Padding(3);
            tabPage_Reader.Size = new Size(793, 470);
            tabPage_Reader.TabIndex = 3;
            tabPage_Reader.Text = "Quản lý độc giả";
            tabPage_Reader.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReader
            // 
            dataGridViewReader.AllowUserToAddRows = false;
            dataGridViewReader.AllowUserToDeleteRows = false;
            dataGridViewReader.AllowUserToResizeColumns = false;
            dataGridViewReader.AllowUserToResizeRows = false;
            dataGridViewReader.AutoGenerateColumns = false;
            dataGridViewReader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReader.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, createAtDataGridViewTextBoxColumn });
            dataGridViewReader.DataSource = readerBindingSource;
            dataGridViewReader.Location = new Point(0, 0);
            dataGridViewReader.Name = "dataGridViewReader";
            dataGridViewReader.ReadOnly = true;
            dataGridViewReader.RowHeadersVisible = false;
            dataGridViewReader.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReader.Size = new Size(433, 470);
            dataGridViewReader.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID Độc giả";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 40;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Tên độc giả";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "SĐT";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 90;
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
            // readerBindingSource
            // 
            readerBindingSource.DataSource = typeof(Models.HumanModel.Reader);
            // 
            // tabPage_StaffManagment
            // 
            tabPage_StaffManagment.Controls.Add(dataGridViewStaff);
            tabPage_StaffManagment.Location = new Point(4, 24);
            tabPage_StaffManagment.Name = "tabPage_StaffManagment";
            tabPage_StaffManagment.Padding = new Padding(3);
            tabPage_StaffManagment.Size = new Size(793, 470);
            tabPage_StaffManagment.TabIndex = 4;
            tabPage_StaffManagment.Text = "Quản lý nhân viên";
            tabPage_StaffManagment.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStaff
            // 
            dataGridViewStaff.AllowUserToAddRows = false;
            dataGridViewStaff.AllowUserToDeleteRows = false;
            dataGridViewStaff.AllowUserToResizeColumns = false;
            dataGridViewStaff.AllowUserToResizeRows = false;
            dataGridViewStaff.AutoGenerateColumns = false;
            dataGridViewStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaff.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, fullNameDataGridViewTextBoxColumn1, phoneNumberDataGridViewTextBoxColumn1, roleDataGridViewTextBoxColumn, defaultStartDataGridViewTextBoxColumn, defaultEndDataGridViewTextBoxColumn });
            dataGridViewStaff.DataSource = staffBindingSource;
            dataGridViewStaff.Location = new Point(0, 0);
            dataGridViewStaff.Name = "dataGridViewStaff";
            dataGridViewStaff.ReadOnly = true;
            dataGridViewStaff.RowHeadersVisible = false;
            dataGridViewStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStaff.Size = new Size(465, 470);
            dataGridViewStaff.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "ID";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn1.HeaderText = "Họ và Tên";
            fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            fullNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn1
            // 
            phoneNumberDataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn1.HeaderText = "SĐT";
            phoneNumberDataGridViewTextBoxColumn1.Name = "phoneNumberDataGridViewTextBoxColumn1";
            phoneNumberDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultStartDataGridViewTextBoxColumn
            // 
            defaultStartDataGridViewTextBoxColumn.DataPropertyName = "DefaultStart";
            defaultStartDataGridViewTextBoxColumn.HeaderText = "Thời gian bắt đầu làm";
            defaultStartDataGridViewTextBoxColumn.Name = "defaultStartDataGridViewTextBoxColumn";
            defaultStartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defaultEndDataGridViewTextBoxColumn
            // 
            defaultEndDataGridViewTextBoxColumn.DataPropertyName = "DefaultEnd";
            defaultEndDataGridViewTextBoxColumn.HeaderText = "Thời gian kết thúc làm";
            defaultEndDataGridViewTextBoxColumn.Name = "defaultEndDataGridViewTextBoxColumn";
            defaultEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataSource = typeof(Models.HumanModel.Staff);
            // 
            // loanBindingSource
            // 
            loanBindingSource.DataSource = typeof(Models.BorrowReturn.Loan);
            // 
            // loanDetailIdDataGridViewTextBoxColumn
            // 
            loanDetailIdDataGridViewTextBoxColumn.DataPropertyName = "LoanDetailId";
            loanDetailIdDataGridViewTextBoxColumn.HeaderText = "ID Chi tiết";
            loanDetailIdDataGridViewTextBoxColumn.Name = "loanDetailIdDataGridViewTextBoxColumn";
            loanDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            loanDetailIdDataGridViewTextBoxColumn.Width = 70;
            // 
            // loanIdDataGridViewTextBoxColumn
            // 
            loanIdDataGridViewTextBoxColumn.DataPropertyName = "LoanId";
            loanIdDataGridViewTextBoxColumn.HeaderText = "ID Phiếu";
            loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
            loanIdDataGridViewTextBoxColumn.ReadOnly = true;
            loanIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // readerNameDataGridViewTextBoxColumn
            // 
            readerNameDataGridViewTextBoxColumn.DataPropertyName = "ReaderName";
            readerNameDataGridViewTextBoxColumn.HeaderText = "Tên độc giả";
            readerNameDataGridViewTextBoxColumn.Name = "readerNameDataGridViewTextBoxColumn";
            readerNameDataGridViewTextBoxColumn.ReadOnly = true;
            readerNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            bookTitleDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            bookTitleDataGridViewTextBoxColumn.Width = 150;
            // 
            // barcodeDataGridViewTextBoxColumn1
            // 
            barcodeDataGridViewTextBoxColumn1.DataPropertyName = "Barcode";
            barcodeDataGridViewTextBoxColumn1.HeaderText = "Mã vạch";
            barcodeDataGridViewTextBoxColumn1.Name = "barcodeDataGridViewTextBoxColumn1";
            barcodeDataGridViewTextBoxColumn1.ReadOnly = true;
            barcodeDataGridViewTextBoxColumn1.Width = 80;
            // 
            // loanDateDataGridViewTextBoxColumn
            // 
            loanDateDataGridViewTextBoxColumn.DataPropertyName = "LoanDate";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = "-";
            loanDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            loanDateDataGridViewTextBoxColumn.HeaderText = "Ngày mượn";
            loanDateDataGridViewTextBoxColumn.Name = "loanDateDataGridViewTextBoxColumn";
            loanDateDataGridViewTextBoxColumn.ReadOnly = true;
            loanDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = "-";
            dueDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            dueDateDataGridViewTextBoxColumn.HeaderText = "Ngày hẹn trả";
            dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            dueDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // returnedDateDataGridViewTextBoxColumn
            // 
            returnedDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnedDate";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = "-";
            returnedDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            returnedDateDataGridViewTextBoxColumn.HeaderText = "Ngày trả thực";
            returnedDateDataGridViewTextBoxColumn.Name = "returnedDateDataGridViewTextBoxColumn";
            returnedDateDataGridViewTextBoxColumn.ReadOnly = true;
            returnedDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn1.HeaderText = "Trạng thái";
            statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            statusDataGridViewTextBoxColumn1.ReadOnly = true;
            statusDataGridViewTextBoxColumn1.Width = 110;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            fineDataGridViewTextBoxColumn.DataPropertyName = "Fine";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            fineDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            fineDataGridViewTextBoxColumn.HeaderText = "Tiền phạt";
            fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            fineDataGridViewTextBoxColumn.ReadOnly = true;
            fineDataGridViewTextBoxColumn.Width = 85;
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            staffNameDataGridViewTextBoxColumn.DataPropertyName = "StaffName";
            staffNameDataGridViewTextBoxColumn.HeaderText = "Nhân viên";
            staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            staffNameDataGridViewTextBoxColumn.ReadOnly = true;
            staffNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // copyIdDataGridViewTextBoxColumn1
            // 
            copyIdDataGridViewTextBoxColumn1.DataPropertyName = "CopyId";
            copyIdDataGridViewTextBoxColumn1.HeaderText = "CopyId";
            copyIdDataGridViewTextBoxColumn1.Name = "copyIdDataGridViewTextBoxColumn1";
            copyIdDataGridViewTextBoxColumn1.ReadOnly = true;
            copyIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // depositDataGridViewTextBoxColumn
            // 
            depositDataGridViewTextBoxColumn.DataPropertyName = "Deposit";
            depositDataGridViewTextBoxColumn.HeaderText = "Deposit";
            depositDataGridViewTextBoxColumn.Name = "depositDataGridViewTextBoxColumn";
            depositDataGridViewTextBoxColumn.ReadOnly = true;
            depositDataGridViewTextBoxColumn.Visible = false;
            // 
            // readerIdDataGridViewTextBoxColumn
            // 
            readerIdDataGridViewTextBoxColumn.DataPropertyName = "ReaderId";
            readerIdDataGridViewTextBoxColumn.HeaderText = "ReaderId";
            readerIdDataGridViewTextBoxColumn.Name = "readerIdDataGridViewTextBoxColumn";
            readerIdDataGridViewTextBoxColumn.ReadOnly = true;
            readerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // readerPhoneDataGridViewTextBoxColumn
            // 
            readerPhoneDataGridViewTextBoxColumn.DataPropertyName = "ReaderPhone";
            readerPhoneDataGridViewTextBoxColumn.HeaderText = "ReaderPhone";
            readerPhoneDataGridViewTextBoxColumn.Name = "readerPhoneDataGridViewTextBoxColumn";
            readerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            readerPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            staffIdDataGridViewTextBoxColumn.HeaderText = "StaffId";
            staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            staffIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // loanNoteDataGridViewTextBoxColumn
            // 
            loanNoteDataGridViewTextBoxColumn.DataPropertyName = "LoanNote";
            loanNoteDataGridViewTextBoxColumn.HeaderText = "LoanNote";
            loanNoteDataGridViewTextBoxColumn.Name = "loanNoteDataGridViewTextBoxColumn";
            loanNoteDataGridViewTextBoxColumn.ReadOnly = true;
            loanNoteDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookIdDataGridViewTextBoxColumn2
            // 
            bookIdDataGridViewTextBoxColumn2.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn2.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn2.Name = "bookIdDataGridViewTextBoxColumn2";
            bookIdDataGridViewTextBoxColumn2.ReadOnly = true;
            bookIdDataGridViewTextBoxColumn2.Visible = false;
            // 
            // bookAuthorDataGridViewTextBoxColumn1
            // 
            bookAuthorDataGridViewTextBoxColumn1.DataPropertyName = "BookAuthor";
            bookAuthorDataGridViewTextBoxColumn1.HeaderText = "BookAuthor";
            bookAuthorDataGridViewTextBoxColumn1.Name = "bookAuthorDataGridViewTextBoxColumn1";
            bookAuthorDataGridViewTextBoxColumn1.ReadOnly = true;
            bookAuthorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iSBNDataGridViewTextBoxColumn1
            // 
            iSBNDataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            iSBNDataGridViewTextBoxColumn1.HeaderText = "ISBN";
            iSBNDataGridViewTextBoxColumn1.Name = "iSBNDataGridViewTextBoxColumn1";
            iSBNDataGridViewTextBoxColumn1.ReadOnly = true;
            iSBNDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bookMoneyDataGridViewTextBoxColumn1
            // 
            bookMoneyDataGridViewTextBoxColumn1.DataPropertyName = "BookMoney";
            bookMoneyDataGridViewTextBoxColumn1.HeaderText = "BookMoney";
            bookMoneyDataGridViewTextBoxColumn1.Name = "bookMoneyDataGridViewTextBoxColumn1";
            bookMoneyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // publisherNameDataGridViewTextBoxColumn1
            // 
            publisherNameDataGridViewTextBoxColumn1.DataPropertyName = "PublisherName";
            publisherNameDataGridViewTextBoxColumn1.HeaderText = "PublisherName";
            publisherNameDataGridViewTextBoxColumn1.Name = "publisherNameDataGridViewTextBoxColumn1";
            publisherNameDataGridViewTextBoxColumn1.ReadOnly = true;
            publisherNameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // isReturnedDataGridViewCheckBoxColumn
            // 
            isReturnedDataGridViewCheckBoxColumn.DataPropertyName = "IsReturned";
            isReturnedDataGridViewCheckBoxColumn.HeaderText = "IsReturned";
            isReturnedDataGridViewCheckBoxColumn.Name = "isReturnedDataGridViewCheckBoxColumn";
            isReturnedDataGridViewCheckBoxColumn.ReadOnly = true;
            isReturnedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // isOverdueDataGridViewCheckBoxColumn
            // 
            isOverdueDataGridViewCheckBoxColumn.DataPropertyName = "IsOverdue";
            isOverdueDataGridViewCheckBoxColumn.HeaderText = "IsOverdue";
            isOverdueDataGridViewCheckBoxColumn.Name = "isOverdueDataGridViewCheckBoxColumn";
            isOverdueDataGridViewCheckBoxColumn.ReadOnly = true;
            isOverdueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // daysOverdueDataGridViewTextBoxColumn
            // 
            daysOverdueDataGridViewTextBoxColumn.DataPropertyName = "DaysOverdue";
            daysOverdueDataGridViewTextBoxColumn.HeaderText = "DaysOverdue";
            daysOverdueDataGridViewTextBoxColumn.Name = "daysOverdueDataGridViewTextBoxColumn";
            daysOverdueDataGridViewTextBoxColumn.ReadOnly = true;
            daysOverdueDataGridViewTextBoxColumn.Visible = false;
            // 
            // totalFineDataGridViewTextBoxColumn
            // 
            totalFineDataGridViewTextBoxColumn.DataPropertyName = "TotalFine";
            totalFineDataGridViewTextBoxColumn.HeaderText = "TotalFine";
            totalFineDataGridViewTextBoxColumn.Name = "totalFineDataGridViewTextBoxColumn";
            totalFineDataGridViewTextBoxColumn.ReadOnly = true;
            totalFineDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 498);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thư viện";
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage_Book.ResumeLayout(false);
            tabPage_Book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            tabPage_BookCopy.ResumeLayout(false);
            tabPage_BookCopy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookCopyBindingSource).EndInit();
            tabPage_ReturnBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLoan).EndInit();
            tabPage_Reader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReader).EndInit();
            ((System.ComponentModel.ISupportInitialize)readerBindingSource).EndInit();
            tabPage_StaffManagment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loanBindingSource).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_Book;
        private TabPage tabPage_BookCopy;
        private TabPage tabPage_ReturnBorrow;
        private TabPage tabPage_Reader;
        private DataGridView dataGridViewBook;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
        private BindingSource bookBindingSource;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnAdd;
        private Label label5;
        private TextBox txtPublishYear;
        private Label label4;
        private TextBox txtBookAuthor;
        private Label label3;
        private TextBox txtCategory;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtISBN;
        private TabPage tabPage_StaffManagment;
        private DataGridView dataGridViewBookCopy;
        private BindingSource bookCopyBindingSource;
        private Label label7;
        private Label label6;
        private ComboBox cbIDBook;
        private Button btnRemoveBookCopy;
        private Button btnEditBookCopy;
        private Button btnAddBookCopy;
        private TextBox txtPublisher;
        private TextBox txtBookMoney;
        private TextBox txtStorageNote;
        private TextBox txtBarCode;
        private Label label10;
        private DataGridViewTextBoxColumn copyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageNoteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookMoneyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private ComboBox cbStatus;
        private Label label11;
        private Label label9;
        private Label label8;
        private DataGridView dataGridViewReader;
        private DataGridView dataGridViewStaff;
        private BindingSource staffBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn defaultEndDataGridViewTextBoxColumn;
        private BindingSource readerBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createAtDataGridViewTextBoxColumn;
        private Button btnViewLoanDetails;
        private Button btnCreateLoan;
        private Button btnReturnBook;
        private DataGridView dataGridViewLoan;
        private BindingSource loanBindingSource;
        private DataGridViewTextBoxColumn loanDetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn loanDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn copyIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn depositDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn readerPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loanNoteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn bookMoneyDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn publisherNameDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isReturnedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isOverdueDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn daysOverdueDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalFineDataGridViewTextBoxColumn;
    }
}