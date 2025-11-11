using LibraryManager.Models.BookModel;
using Managment.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            NotAdmin();
        }

        public string UserRole { get; set; }

        private DataTable _books = new DataTable();

        private DataTable _bookCopies = new DataTable();

        private DataTable _loanDetails = new DataTable();

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReloadBookFromDB();
            ReloadBookCopyFromDB();
            LoadBookList();
            LoadStatusList();
            ReloadLoanDetailsFromDB();
        }

        private void LoadStatusList()
        {
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Lost");      // index 0 -> value -1
            cbStatus.Items.Add("Available"); // index 1 -> value 0
            cbStatus.Items.Add("OnLoan");    // index 2 -> value 1
            cbStatus.Items.Add("Damaged");   // index 3 -> value 2
            cbStatus.SelectedIndex = 1; // Mặc định Available
        }

        private void LoadBookList()
        {
            try
            {
                var dt = Db.Query(@"SELECT BookId, Title FROM Book ORDER BY BookId");

                cbIDBook.DataSource = dt;
                cbIDBook.DisplayMember = "Title"; // Hiển thị tên sách
                cbIDBook.ValueMember = "BookId";  // Giá trị là BookId
                cbIDBook.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách Book:\n" + ex.Message, "Lỗi");
            }
        }

        private void NotAdmin()
        {
            if (UserRole != "admin")
            {
                TabPage tabPage = tabControl1.TabPages["tabPage_StaffManagment"];
                if (tabPage != null)
                {
                    tabControl1.TabPages.Remove(tabPage);
                }
            }
        }

        private bool TryGetInputsBook(out string isbn, out string title, out string category, out string author, out int year)
        {
            isbn = txtISBN.Text.Trim();
            title = txtTitle.Text.Trim();
            category = txtCategory.Text.Trim();
            author = txtBookAuthor.Text.Trim();

            if (!int.TryParse(txtPublishYear.Text.Trim(), out year))
            {
                MessageBox.Show("Năm xuất bản phải là số nguyên.");
                txtPublishYear.Focus();
                return false;
            }
            if (year < 868 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Năm xuất bản phải từ 868 đến {DateTime.Now.Year}.");
                txtPublishYear.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(isbn) || string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Mã số tiêu chuẩn Quốc tế và Tên sách không được để trống.");
                return false;
            }
            return true;
        }
        private bool TryGetInputsBookCopy(out int bookId, out string barcode, out string storagenote,
            out decimal bookmoney, out string publisher, out int statusValue)
        {
            barcode = txtBarCode.Text.Trim();
            storagenote = txtStorageNote.Text.Trim();
            publisher = txtPublisher.Text.Trim();
            bookmoney = 0;

            // Kiểm tra BookId
            if (cbIDBook.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầu sách.");
                cbIDBook.Focus();
                bookId = 0;
                statusValue = 0;
                return false;
            }
            bookId = Convert.ToInt32(cbIDBook.SelectedValue);

            // Kiểm tra BookMoney
            if (!decimal.TryParse(txtBookMoney.Text.Trim(), out bookmoney))
            {
                MessageBox.Show("Giá tiền phải là số.");
                txtBookMoney.Focus();
                statusValue = 0;
                return false;
            }

            // Kiểm tra Status
            if (cbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.");
                cbStatus.Focus();
                statusValue = 0;
                return false;
            }

            switch (cbStatus.SelectedIndex)
            {
                case 0: statusValue = -1; break; // Lost
                case 1: statusValue = 0; break;  // Available
                case 2: statusValue = 1; break;  // OnLoan
                case 3: statusValue = 2; break;  // Damaged
                default: statusValue = 0; break;
            }

            if (string.IsNullOrWhiteSpace(barcode) || string.IsNullOrWhiteSpace(publisher))
            {
                MessageBox.Show("Mã vạch và Nhà xuất bản không được để trống.");
                return false;
            }

            return true;
        }

        private void ReloadBookFromDB()
        {
            try
            {
                _books = Db.Query(@"SELECT BookId, ISBN, Title, CategoryName, BookAuthor, PublishYear FROM Book ORDER BY BookId");
                bookBindingSource.DataSource = _books;
                bookBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Book từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

        private int? GetSelectedBookId()
        {
            if (dataGridViewBook.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["BookId"]);
            return null;
        }

        private void ReloadBookCopyFromDB()
        {
            try
            {
                try
                {
                    _bookCopies = Db.Query(@"
                    SELECT 
                        bc.CopyId,
                        bc.BookId,
                        bc.Barcode,
                        bc.StorageNote,
                        bc.BookMoney,
                        bc.PublisherName,
                        bc.Status
                    FROM BookCopy bc
                    ORDER BY bc.CopyId");

                    bookCopyBindingSource.DataSource = _bookCopies;
                    bookCopyBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tải được dữ liệu BookCopy từ SQL:\n" + ex.Message, "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Book từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

        private int? GetSelectedCopyId()
        {
            if (dataGridViewBookCopy.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["CopyId"]);
            return null;
        }

        #region tabpage_Book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!TryGetInputsBook(out var isbn, out var title, out var category, out var author, out var year))
                return;

            // KHÔNG gửi BookId; IDENTITY tự tăng
            const string sql = @"
            INSERT INTO Book (ISBN, Title, CategoryName, BookAuthor, PublishYear)
            VALUES (@ISBN, @Title, @CategoryName, @BookAuthor, @PublishYear);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@ISBN", SqlDbType.VarChar, 255).Value = (object?)isbn ?? DBNull.Value;
                    p.Add("@Title", SqlDbType.NVarChar, 255).Value = (object?)title ?? DBNull.Value;
                    p.Add("@CategoryName", SqlDbType.NVarChar, 255).Value = (object?)category ?? DBNull.Value;
                    p.Add("@BookAuthor", SqlDbType.NVarChar, 255).Value = (object?)author ?? DBNull.Value;
                    p.Add("@PublishYear", SqlDbType.SmallInt).Value = year;
                });
                ReloadBookFromDB();
                dataGridViewBook.ClearSelection();
                if (dataGridViewBook.Rows.Count > 0) dataGridViewBook.Rows[0].Selected = true; // select hàng mới nhất
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm sách thất bại:\n" + ex.Message);
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            var id = GetSelectedBookId();
            if (id == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa.");
                return;
            }
            if (!TryGetInputsBook(out var isbn, out var title, out var category, out var author, out var year))
                return;

            const string sql = @"
            UPDATE Book
            SET ISBN=@ISBN, Title=@Title, CategoryName=@CategoryName, BookAuthor=@BookAuthor, PublishYear=@PublishYear
            WHERE BookId=@BookId;";

            try
            {
                var rows = Db.Execute(sql, p =>
                {
                    p.Add("@ISBN", SqlDbType.VarChar, 255).Value = (object?)isbn ?? DBNull.Value;  // ISBN: VarChar ok
                    p.Add("@Title", SqlDbType.NVarChar, 255).Value = (object?)title ?? DBNull.Value;
                    p.Add("@CategoryName", SqlDbType.NVarChar, 255).Value = (object?)category ?? DBNull.Value;
                    p.Add("@BookAuthor", SqlDbType.NVarChar, 255).Value = (object?)author ?? DBNull.Value;
                    p.Add("@PublishYear", SqlDbType.SmallInt).Value = year; // hoặc DBNull.Value nếu cho phép null
                    p.Add("@BookId", SqlDbType.Int).Value = id.Value;
                });
                if (rows == 0) MessageBox.Show("Không tìm thấy BookId để cập nhật.");
                ReloadBookFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa sách thất bại:\n" + ex.Message);
            }
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá.");
                return;
            }

            var q = MessageBox.Show("Bạn có chắc muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.No)
                return;

            try
            {
                using var conn = Db.Open();
                foreach (DataGridViewRow row in dataGridViewBook.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        int id = Convert.ToInt32(drv.Row["BookId"]);
                        using var cmd = new SqlCommand("DELETE FROM Book WHERE BookId=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                ReloadBookFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá thất bại:\n" + ex.Message);
            }
        }

        private void dataGridViewBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridViewBook.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;
                txtISBN.Text = r["ISBN"]?.ToString() ?? "";
                txtTitle.Text = r["Title"]?.ToString() ?? "";
                txtCategory.Text = r["CategoryName"]?.ToString() ?? "";
                txtBookAuthor.Text = r["BookAuthor"]?.ToString() ?? "";
                txtPublishYear.Text = r["PublishYear"]?.ToString() ?? "";
                return;
            }

            if (gridRow.DataBoundItem is Book book)
            {
                txtISBN.Text = book.ISBN ?? "";
                txtTitle.Text = book.Title ?? "";
                txtCategory.Text = book.CategoryName ?? "";
                txtBookAuthor.Text = book.BookAuthor ?? "";
                txtPublishYear.Text = book.PublishYear.ToString();
                return;
            }

            txtISBN.Text = gridRow.Cells["ISBN"]?.Value?.ToString() ?? "";
            txtTitle.Text = gridRow.Cells["Title"]?.Value?.ToString() ?? "";
            txtCategory.Text = gridRow.Cells["CategoryName"]?.Value?.ToString() ?? "";
            txtBookAuthor.Text = gridRow.Cells["BookAuthor"]?.Value?.ToString() ?? "";
            txtPublishYear.Text = gridRow.Cells["PublishYear"]?.Value?.ToString() ?? "";
        }
        #endregion

        #region tabPage_BookCopy
        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            if (!TryGetInputsBookCopy(out int bookId, out string barcode, out string storagenote, out decimal bookmoney, out string publisher, out int statusValue))
                return;

            const string sql = @"
                INSERT INTO BookCopy (BookId, Barcode, StorageNote, BookMoney, PublisherName, Status)
                VALUES (@BookId, @Barcode, @StorageNote, @BookMoney, @PublisherName, @Status);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@BookId", SqlDbType.Int).Value = bookId;
                    p.Add("@Barcode", SqlDbType.VarChar, 255).Value = barcode;
                    p.Add("@StorageNote", SqlDbType.NVarChar, 255).Value = (object?)storagenote ?? DBNull.Value;
                    p.Add("@BookMoney", SqlDbType.Decimal).Value = bookmoney;
                    p.Add("@PublisherName", SqlDbType.NVarChar, 255).Value = publisher;
                    p.Add("@Status", SqlDbType.SmallInt).Value = statusValue;
                });

                ReloadBookCopyFromDB();

                if (dataGridViewBookCopy.Rows.Count > 0)
                {
                    dataGridViewBookCopy.ClearSelection();
                    dataGridViewBookCopy.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm bản sao sách thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnEditBookCopy_Click(object sender, EventArgs e)
        {
            var copyId = GetSelectedCopyId();
            if (copyId == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa.");
                return;
            }

            if (!TryGetInputsBookCopy(out int bookId, out string barcode, out string storagenote,
                out decimal bookmoney, out string publisher, out int statusValue))
                return;

            const string sql = @"
                UPDATE BookCopy
                SET BookId=@BookId, Barcode=@Barcode, StorageNote=@StorageNote, 
                    BookMoney=@BookMoney, PublisherName=@PublisherName, Status=@Status
                WHERE CopyId=@CopyId;";

            try
            {
                var rows = Db.Execute(sql, p =>
                {
                    p.Add("@BookId", SqlDbType.Int).Value = bookId;
                    p.Add("@Barcode", SqlDbType.VarChar, 255).Value = barcode;
                    p.Add("@StorageNote", SqlDbType.NVarChar, 255).Value = (object?)storagenote ?? DBNull.Value;
                    p.Add("@BookMoney", SqlDbType.Decimal).Value = bookmoney;
                    p.Add("@PublisherName", SqlDbType.NVarChar, 255).Value = publisher;
                    p.Add("@Status", SqlDbType.SmallInt).Value = statusValue;
                    p.Add("@CopyId", SqlDbType.Int).Value = copyId.Value;
                });

                if (rows == 0)
                    MessageBox.Show("Không tìm thấy CopyId để cập nhật.");

                ReloadBookCopyFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa bản sao sách thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnRemoveBookCopy_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookCopy.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá.");
                return;
            }

            var q = MessageBox.Show("Bạn có chắc muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.No)
                return;

            try
            {
                using var conn = Db.Open();
                foreach (DataGridViewRow row in dataGridViewBookCopy.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        int id = Convert.ToInt32(drv.Row["CopyId"]);
                        using var cmd = new SqlCommand("DELETE FROM BookCopy WHERE CopyId=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                ReloadBookCopyFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá thất bại:\n" + ex.Message, "Lỗi");
            }
        }
        #endregion

        #region tabPage_Loan
        private void ReloadLoanDetailsFromDB()
        {
            try
            {
                _loanDetails = Db.Query(@"
            SELECT 
                -- LoanDetail
                ld.LoanDetailId,
                ld.LoanId,
                ld.CopyId,
                ld.ReturnedDate,
                ld.Fine,
                ld.Deposit,
                
                -- Loan
                l.ReaderId,
                l.StaffId,
                l.LoanDate,
                l.DueDate,
                l.Note AS LoanNote,
                
                -- Reader
                r.FullName AS ReaderName,
                r.Phone AS ReaderPhone,
                
                -- Staff
                s.FullName AS StaffName,
                
                -- BookCopy & Book
                bc.BookId,
                bc.Barcode,
                bc.BookMoney,
                bc.PublisherName,
                b.Title AS BookTitle,
                b.BookAuthor,
                b.ISBN
                
            FROM LoanDetail ld
            INNER JOIN Loan l ON ld.LoanId = l.LoanId
            INNER JOIN Reader r ON l.ReaderId = r.ReaderId
            INNER JOIN Staff s ON l.StaffId = s.StaffId
            INNER JOIN BookCopy bc ON ld.CopyId = bc.CopyId
            INNER JOIN Book b ON bc.BookId = b.BookId
            ORDER BY l.LoanDate DESC, ld.LoanDetailId
        ");

                // Thêm cột tính toán Status
                if (!_loanDetails.Columns.Contains("Status"))
                {
                    _loanDetails.Columns.Add("Status", typeof(string));
                }

                // Tính Status cho từng dòng
                foreach (DataRow row in _loanDetails.Rows)
                {
                    bool isReturned = row["ReturnedDate"] != DBNull.Value;
                    DateTime dueDate = Convert.ToDateTime(row["DueDate"]);
                    bool isOverdue = !isReturned && DateTime.Now > dueDate;

                    if (isReturned)
                        row["Status"] = "Đã trả";
                    else if (isOverdue)
                    {
                        int daysOverdue = (DateTime.Now - dueDate).Days;
                        row["Status"] = $"Quá hạn {daysOverdue} ngày";
                    }
                    else
                        row["Status"] = "Đang mượn";
                }

                dataGridViewLoan.DataSource = _loanDetails;

                // ConfigureLoanDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Loan từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

        //private void ConfigureLoanDataGridView()
        //{
        //    dataGridViewLoan.AutoGenerateColumns = false;
        //    dataGridViewLoan.Columns.Clear();

        //    // LoanDetailId
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "LoanDetailId",
        //        HeaderText = "ID Chi tiết",
        //        DataPropertyName = "LoanDetailId",
        //        Width = 70,
        //        ReadOnly = true
        //    });

        //    // LoanId
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "LoanId",
        //        HeaderText = "ID Phiếu",
        //        DataPropertyName = "LoanId",
        //        Width = 60,
        //        ReadOnly = true
        //    });

        //    // ReaderName
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "ReaderName",
        //        HeaderText = "Tên độc giả",
        //        DataPropertyName = "ReaderName",
        //        Width = 120,
        //        ReadOnly = true
        //    });

        //    // BookTitle
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "BookTitle",
        //        HeaderText = "Tên sách",
        //        DataPropertyName = "BookTitle",
        //        Width = 150,
        //        ReadOnly = true
        //    });

        //    // Barcode
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Barcode",
        //        HeaderText = "Mã vạch",
        //        DataPropertyName = "Barcode",
        //        Width = 80,
        //        ReadOnly = true
        //    });

        //    // LoanDate
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "LoanDate",
        //        HeaderText = "Ngày mượn",
        //        DataPropertyName = "LoanDate",
        //        Width = 90,
        //        ReadOnly = true,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
        //    });

        //    // DueDate
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "DueDate",
        //        HeaderText = "Ngày hẹn trả",
        //        DataPropertyName = "DueDate",
        //        Width = 95,
        //        ReadOnly = true,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
        //    });

        //    // ReturnedDate
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "ReturnedDate",
        //        HeaderText = "Ngày trả",
        //        DataPropertyName = "ReturnedDate",
        //        Width = 90,
        //        ReadOnly = true,
        //        DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy", NullValue = "-" }
        //    });

        //    // Status
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Status",
        //        HeaderText = "Trạng thái",
        //        DataPropertyName = "Status",
        //        Width = 110,
        //        ReadOnly = true
        //    });

        //    // Fine
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "Fine",
        //        HeaderText = "Tiền phạt",
        //        DataPropertyName = "Fine",
        //        Width = 85,
        //        ReadOnly = true,
        //        DefaultCellStyle = new DataGridViewCellStyle
        //        {
        //            Format = "N0",
        //            NullValue = "0",
        //            Alignment = DataGridViewContentAlignment.MiddleRight
        //        }
        //    });

        //    // StaffName
        //    dataGridViewLoan.Columns.Add(new DataGridViewTextBoxColumn
        //    {
        //        Name = "StaffName",
        //        HeaderText = "Nhân viên",
        //        DataPropertyName = "StaffName",
        //        Width = 120,
        //        ReadOnly = true
        //    });
        //}

        private int? GetSelectedLoanDetailId()
        {
            if (dataGridViewLoan.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["LoanDetailId"]);
            return null;
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            var loanDetailId = GetSelectedLoanDetailId();
            if (loanDetailId == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để trả sách.");
                return;
            }

            // Kiểm tra xem sách đã được trả chưa
            var currentRow = dataGridViewLoan.CurrentRow.DataBoundItem as DataRowView;
            if (currentRow?.Row["ReturnedDate"] != DBNull.Value)
            {
                MessageBox.Show("Sách này đã được trả rồi!");
                return;
            }

            var confirm = MessageBox.Show(
                "Xác nhận trả sách này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
                return;

            const string sql = @"
        UPDATE LoanDetail
        SET ReturnedDate = SYSDATETIME()
        WHERE LoanDetailId = @LoanDetailId;
        
        -- Cập nhật Status của BookCopy về Available
        UPDATE BookCopy
        SET Status = 0
        WHERE CopyId = (SELECT CopyId FROM LoanDetail WHERE LoanDetailId = @LoanDetailId);
    ";

            try
            {
                var rows = Db.Execute(sql, p =>
                {
                    p.Add("@LoanDetailId", SqlDbType.Int).Value = loanDetailId.Value;
                });

                if (rows > 0)
                {
                    MessageBox.Show("Trả sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReloadLoanDetailsFromDB();
                    ReloadBookCopyFromDB(); // Cập nhật lại bảng BookCopy
                }
                else
                {
                    MessageBox.Show("Không tìm thấy LoanDetailId để cập nhật.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Trả sách thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            // Mở form tạo phiếu mượn mới
            var createLoanForm = new frmCreateLoan();
            if (createLoanForm.ShowDialog() == DialogResult.OK)
            {
                ReloadLoanDetailsFromDB();
                ReloadBookCopyFromDB();
            }
        }

        private void btnViewLoanDetails_Click(object sender, EventArgs e)
        {
            var loanDetailId = GetSelectedLoanDetailId();
            if (loanDetailId == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để xem chi tiết.");
                return;
            }

            var currentRow = dataGridViewLoan.CurrentRow.DataBoundItem as DataRowView;
            if (currentRow == null) return;

            var details = $@"
=== THÔNG TIN CHI TIẾT MƯỢN SÁCH ===

ID Chi tiết: {currentRow.Row["LoanDetailId"]}
ID Phiếu mượn: {currentRow.Row["LoanId"]}

--- Thông tin độc giả ---
Tên: {currentRow.Row["ReaderName"]}
SĐT: {currentRow.Row["ReaderPhone"]}

--- Thông tin sách ---
Tên sách: {currentRow.Row["BookTitle"]}
Tác giả: {currentRow.Row["BookAuthor"]}
ISBN: {currentRow.Row["ISBN"]}
Mã vạch: {currentRow.Row["Barcode"]}
Giá sách: {Convert.ToDecimal(currentRow.Row["BookMoney"]):N0} VNĐ
Nhà xuất bản: {currentRow.Row["PublisherName"]}

--- Thông tin mượn trả ---
Ngày mượn: {Convert.ToDateTime(currentRow.Row["LoanDate"]):dd/MM/yyyy}
Ngày hẹn trả: {Convert.ToDateTime(currentRow.Row["DueDate"]):dd/MM/yyyy}
Ngày trả thực tế: {(currentRow.Row["ReturnedDate"] == DBNull.Value ? "Chưa trả" : Convert.ToDateTime(currentRow.Row["ReturnedDate"]).ToString("dd/MM/yyyy"))}
Trạng thái: {currentRow.Row["Status"]}

Tiền cọc: {(currentRow.Row["Deposit"] == DBNull.Value ? "0" : Convert.ToDecimal(currentRow.Row["Deposit"]).ToString("N0"))} VNĐ
Tiền phạt: {(currentRow.Row["Fine"] == DBNull.Value ? "0" : Convert.ToDecimal(currentRow.Row["Fine"]).ToString("N0"))} VNĐ

Nhân viên xử lý: {currentRow.Row["StaffName"]}
Ghi chú: {(currentRow.Row["LoanNote"] == DBNull.Value ? "(Không có)" : currentRow.Row["LoanNote"])}
";

            MessageBox.Show(details, "Chi tiết phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region tabPage_Staff

        #endregion
    }
}
