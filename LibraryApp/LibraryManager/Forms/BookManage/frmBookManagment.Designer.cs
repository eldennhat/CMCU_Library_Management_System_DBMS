namespace LibraryManager.Forms.BookManage
{
    partial class frmBookManagment
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
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iSBNDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookAuthorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            publishYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtISBNBook = new TextBox();
            txtTitleBook = new TextBox();
            txtCategoryName = new TextBox();
            txtAuthorName = new TextBox();
            txtPublishYear = new TextBox();
            btnAddBook = new Button();
            btnEditBook = new Button();
            btnDeleteBook = new Button();
            btnDeleteAll = new Button();
            btnExportFile = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookIdDataGridViewTextBoxColumn, iSBNDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, categoryNameDataGridViewTextBoxColumn, bookAuthorDataGridViewTextBoxColumn, publishYearDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookBindingSource;
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(573, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            titleDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            categoryNameDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            categoryNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            bookAuthorDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
            publishYearDataGridViewTextBoxColumn.HeaderText = "Năm xuất bản";
            publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            publishYearDataGridViewTextBoxColumn.ReadOnly = true;
            publishYearDataGridViewTextBoxColumn.Width = 50;
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataSource = typeof(Models.BookManage.Book);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(619, 42);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "MSTC Quốc tế";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(649, 70);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 99);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Thể loại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 128);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "Tên tác giả";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(621, 157);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 5;
            label5.Text = "Năm xuất bản";
            // 
            // txtISBNBook
            // 
            txtISBNBook.BorderStyle = BorderStyle.FixedSingle;
            txtISBNBook.Location = new Point(708, 39);
            txtISBNBook.Name = "txtISBNBook";
            txtISBNBook.Size = new Size(100, 23);
            txtISBNBook.TabIndex = 6;
            // 
            // txtTitleBook
            // 
            txtTitleBook.BorderStyle = BorderStyle.FixedSingle;
            txtTitleBook.Location = new Point(708, 68);
            txtTitleBook.Name = "txtTitleBook";
            txtTitleBook.Size = new Size(142, 23);
            txtTitleBook.TabIndex = 7;
            // 
            // txtCategoryName
            // 
            txtCategoryName.BorderStyle = BorderStyle.FixedSingle;
            txtCategoryName.Location = new Point(708, 97);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(116, 23);
            txtCategoryName.TabIndex = 8;
            // 
            // txtAuthorName
            // 
            txtAuthorName.BorderStyle = BorderStyle.FixedSingle;
            txtAuthorName.Location = new Point(708, 126);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(164, 23);
            txtAuthorName.TabIndex = 9;
            // 
            // txtPublishYear
            // 
            txtPublishYear.BorderStyle = BorderStyle.FixedSingle;
            txtPublishYear.Location = new Point(708, 155);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(65, 23);
            txtPublishYear.TabIndex = 10;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(604, 202);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(61, 32);
            btnAddBook.TabIndex = 11;
            btnAddBook.Text = "Thêm";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(692, 202);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(58, 32);
            btnEditBook.TabIndex = 12;
            btnEditBook.Text = "Sửa";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(786, 202);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(58, 32);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Xoá";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Red;
            btnDeleteAll.Location = new Point(874, 202);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(69, 32);
            btnDeleteAll.TabIndex = 14;
            btnDeleteAll.Text = "Xoá tất cả";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnExportFile
            // 
            btnExportFile.Location = new Point(604, 262);
            btnExportFile.Name = "btnExportFile";
            btnExportFile.Size = new Size(339, 23);
            btnExportFile.TabIndex = 15;
            btnExportFile.Text = "Xuất file excel";
            btnExportFile.UseVisualStyleBackColor = true;
            btnExportFile.Click += btnExportFile_Click;
            // 
            // frmBookManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(969, 450);
            Controls.Add(btnExportFile);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnEditBook);
            Controls.Add(btnAddBook);
            Controls.Add(txtPublishYear);
            Controls.Add(txtAuthorName);
            Controls.Add(txtCategoryName);
            Controls.Add(txtTitleBook);
            Controls.Add(txtISBNBook);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmBookManagment";
            Text = "Quản lý sách";
            Load += frmBookManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtISBNBook;
        private TextBox txtTitleBook;
        private TextBox txtCategoryName;
        private TextBox txtAuthorName;
        private TextBox txtPublishYear;
        private Button btnAddBook;
        private Button btnEditBook;
        private Button btnDeleteBook;
        private BindingSource bookBindingSource;
        private Button btnDeleteAll;
        private Button btnExportFile;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
    }
}