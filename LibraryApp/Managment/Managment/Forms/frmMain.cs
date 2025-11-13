using LibraryManager.Models.BookModel;
using Managment.Database;
using Managment.Models.HumanModel;
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

        private DataTable _reader = new DataTable();

        private DataTable _staff = new DataTable();

        private frmRegister formRegister;

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReloadBookFromDB();
            ReloadBookCopyFromDB();
            LoadBookList();
            LoadStatusList();
            ReloadLoanDetailsFromDB();
            ReloadReaderFromDB();
            ReloadStaffFromDB();
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
            if (UserRole == "Librarian")
            {
                TabPage tabPage = tabControl1.TabPages["tabPage_StaffManagment"];
                if (tabPage != null)
                {
                    tabControl1.TabPages.Remove(tabPage);
                }
            }
        }

        #region Helper_Book
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
        #endregion

        #region Helper_BookCopy
        private bool TryGetInputsBookCopy(out int bookId, out string barcode, out string storagenote,
    out decimal bookmoney, out string publisher, out int statusValue)
        {
            barcode = txtBarCode.Text.Trim();
            storagenote = txtStorageNote.Text.Trim();
            publisher = txtPublisher.Text.Trim();
            bookmoney = 0;

            if (cbIDBook.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn đầu sách.");
                cbIDBook.Focus();
                bookId = 0;
                statusValue = 0;
                return false;
            }
            bookId = Convert.ToInt32(cbIDBook.SelectedValue);

            if (!decimal.TryParse(txtBookMoney.Text.Trim(), out bookmoney))
            {
                MessageBox.Show("Giá tiền phải là số.");
                txtBookMoney.Focus();
                statusValue = 0;
                return false;
            }

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
        #endregion

        #region Helper_Reader
        private bool TryGetInputsReaders(out string readerFullName, out string readerPhoneNumber, out string readerAddress, out DateTime timeCreate)
        {
            readerFullName = txtReaderName.Text.Trim();
            readerPhoneNumber = txtReaderPhoneNumber.Text.Trim();
            readerAddress = txtReaderAddress.Text.Trim();

            DateTime.TryParse(dtpReaderCreated.Text, out timeCreate);

            if (string.IsNullOrEmpty(readerFullName) || string.IsNullOrEmpty(readerPhoneNumber) || string.IsNullOrEmpty(readerAddress) || dtpReaderCreated.Text == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin độc giả.");
                return false;
            }
            return true;
        }

        private void ReloadReaderFromDB()
        {
            try
            {
                _reader = Db.Query(@"
            SELECT 
                ReaderId AS Id, 
                FullName, 
                Phone AS PhoneNumber, 
                [Address], 
                CreateAt 
            FROM dbo.Reader 
            ORDER BY ReaderId");
                readerBindingSource.DataSource = _reader;
                readerBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Reader từ SQL:\n" + ex.Message, "Lỗi");
            }
        }


        private int? GetSelectedReaderId()
        {
            if (dataGridViewReader.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["ReaderId"]);
            return null;
        }
        #endregion

        #region Helper_Staff
        private void ReloadStaffFromDB()
        {
            try
            {
                _staff = Db.Query(@"
            SELECT 
                StaffId as Id, 
                FullName, 
                Phone as PhoneNumber,
                [Role],
                DefaultStart, 
                DefaultEnd 
            FROM Staff 
            ORDER BY StaffId");

                staffBindingSource.DataSource = _staff;
                staffBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Staff từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

        private int? GetSelectedStaffId()
        {
            if (dataGridViewStaff.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["Id"]);
            return null;
        }

        private bool TryGetInputsStaff(out string fullName, out string phone, out TimeOnly defaultStart, out TimeOnly defaultEnd)
        {
            fullName = txtFullNameStaff.Text.Trim();
            phone = txtPhoneStaff.Text.Trim();

            defaultStart = TimeOnly.FromDateTime(dtpTimeStart.Value);
            defaultEnd = TimeOnly.FromDateTime(dtpTimeEnd.Value);

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Họ tên và Số điện thoại.");
                return false;
            }

            if (defaultStart >= defaultEnd)
            {
                MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc.");
                return false;
            }

            return true;
        }
        #endregion

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
                SET BookId=@BookId, Barcode=@Barcode, StorageNote=@StorageNote, BookMoney=@BookMoney, PublisherName=@PublisherName, Status=@Status
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

        private void dataGridViewBookCopy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridViewBookCopy.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;
                if (r["BookId"] != DBNull.Value)
                {
                    cbIDBook.SelectedValue = Convert.ToInt32(r["BookId"]);
                }
                else
                {
                    cbIDBook.SelectedIndex = -1;
                }

                txtBarCode.Text = r["Barcode"]?.ToString() ?? "";
                txtStorageNote.Text = r["StorageNote"]?.ToString() ?? "";

                txtBookMoney.Text = r["BookMoney"] != DBNull.Value
                    ? Convert.ToDecimal(r["BookMoney"]).ToString("0.##") : "0";

                txtPublisher.Text = r["PublisherName"]?.ToString() ?? "";

                // 0: Lost(-1), 1: Available(0), 2: OnLoan(1), 3: Damaged(2)
                // Công thức map: Index = Status + 1
                if (r["Status"] != DBNull.Value)
                {
                    int statusVal = Convert.ToInt32(r["Status"]);
                    int index = statusVal + 1;

                    if (index >= 0 && index < cbStatus.Items.Count)
                    {
                        cbStatus.SelectedIndex = index;
                    }
                }
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
            ORDER BY l.LoanDate DESC, ld.LoanDetailId");

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Loan từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

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

        #region tabPage_Reader
        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (!TryGetInputsReaders(out string readerFullName, out string readerPhoneNumber, out string readerAddress, out DateTime timeCreate))
                return;

            const string sql = @"
        INSERT INTO Reader (FullName, Phone, [Address], CreateAt)
        VALUES (@FullName, @Phone, @Address, @CreateAt);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@FullName", SqlDbType.NVarChar, 255).Value = (object?)readerFullName ?? DBNull.Value;
                    p.Add("@Phone", SqlDbType.NVarChar, 255).Value = (object?)readerPhoneNumber ?? DBNull.Value;
                    p.Add("@Address", SqlDbType.NVarChar, 255).Value = (object?)readerAddress ?? DBNull.Value;
                    p.Add("@CreateAt", SqlDbType.DateTime2).Value = timeCreate;
                });

                MessageBox.Show("Thêm độc giả thành công!", "Thành công");
                ReloadReaderFromDB();

                dataGridViewReader.ClearSelection();
                if (dataGridViewReader.Rows.Count > 0) dataGridViewReader.Rows[0].Selected = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm độc giả thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {
            var id = GetSelectedReaderId();
            if (id == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa.");
                return;
            }

            if (!TryGetInputsReaders(out string readerFullName, out string readerPhoneNumber, out string readerAddress, out DateTime timeCreate))
                return;

            const string sql = @"
        UPDATE Reader
        SET FullName = @FullName, Phone = @Phone, [Address] = @Address, CreateAt = @CreateAt
        WHERE ReaderId = @ReaderId;";

            try
            {
                var rows = Db.Execute(sql, p =>
                {
                    p.Add("@FullName", SqlDbType.NVarChar, 255).Value = (object?)readerFullName ?? DBNull.Value;
                    p.Add("@Phone", SqlDbType.NVarChar, 255).Value = (object?)readerPhoneNumber ?? DBNull.Value;
                    p.Add("@Address", SqlDbType.NVarChar, 255).Value = (object?)readerAddress ?? DBNull.Value;
                    p.Add("@CreateAt", SqlDbType.DateTime2).Value = timeCreate;
                    p.Add("@ReaderId", SqlDbType.Int).Value = id.Value;
                });

                if (rows == 0)
                {
                    MessageBox.Show("Không tìm thấy ReaderId để cập nhật.");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin độc giả thành công!", "Thành công");
                    ReloadReaderFromDB();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa độc giả thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnRemoveReader_Click(object sender, EventArgs e)
        {
            if (dataGridViewReader.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá.");
                return;
            }

            var q = MessageBox.Show("Bạn có chắc muốn xoá độc giả này không?\nLưu ý: Nếu độc giả đã có phiếu mượn sách, bạn không thể xoá!", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (q == DialogResult.No)
                return;

            try
            {
                using var conn = Db.Open();
                foreach (DataGridViewRow row in dataGridViewReader.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        int id = Convert.ToInt32(drv.Row["ReaderId"]);
                        using var cmd = new SqlCommand("DELETE FROM Reader WHERE ReaderId = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xoá độc giả thành công!", "Thành công");
                ReloadReaderFromDB();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint violation
                {
                    MessageBox.Show("Không thể xoá độc giả này vì đã có phiếu mượn sách liên quan!\n\nVui lòng xoá các phiếu mượn trước.", "Lỗi");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại:\n" + ex.Message, "Lỗi");
                }
            }
        }

        private void dataGridViewReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridViewReader.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;
                txtReaderName.Text = r["FullName"]?.ToString() ?? "";
                txtReaderPhoneNumber.Text = r["PhoneNumber"]?.ToString() ?? "";
                txtReaderAddress.Text = r["Address"]?.ToString() ?? "";

                if (r["CreateAt"] != DBNull.Value)
                {
                    dtpReaderCreated.Value = Convert.ToDateTime(r["CreateAt"]);
                }
                return;
            }

            txtReaderName.Text = gridRow.Cells["FullName"]?.Value?.ToString() ?? "";
            txtReaderPhoneNumber.Text = gridRow.Cells["PhoneNumber"]?.Value?.ToString() ?? "";
            txtReaderAddress.Text = gridRow.Cells["Address"]?.Value?.ToString() ?? "";

            if (gridRow.Cells["CreateAt"]?.Value != null && gridRow.Cells["CreateAt"].Value != DBNull.Value)
            {
                dtpReaderCreated.Value = Convert.ToDateTime(gridRow.Cells["CreateAt"].Value);
            }
        }
        #endregion

        #region tabPage_Staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (!TryGetInputsStaff(out string fullName, out string phone, out TimeOnly defaultStart, out TimeOnly defaultEnd))
                return;

            const string sql = @"
        INSERT INTO Staff (FullName, Phone, [Role],DefaultStart, DefaultEnd)
        VALUES (@FullName, @Phone, @Role, @DefaultStart, @DefaultEnd);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@FullName", SqlDbType.NVarChar, 255).Value = fullName;
                    p.Add("@Phone", SqlDbType.NVarChar, 255).Value = phone;
                    p.Add("@Role", SqlDbType.VarChar, 255).Value = "Librarian";
                    p.Add("@DefaultStart", SqlDbType.Time).Value = defaultStart.ToTimeSpan();
                    p.Add("@DefaultEnd", SqlDbType.Time).Value = defaultEnd.ToTimeSpan();
                });

                MessageBox.Show("Thêm nhân viên thành công!", "Thành công");
                ReloadStaffFromDB();

                if (dataGridViewStaff.Rows.Count > 0)
                {
                    dataGridViewStaff.ClearSelection();
                    dataGridViewStaff.Rows[0].Selected = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm nhân viên thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            var staffId = GetSelectedStaffId();
            if (staffId == null)
            {
                MessageBox.Show("Hãy chọn 1 dòng để sửa.");
                return;
            }

            if (!TryGetInputsStaff(out string fullName, out string phone, out TimeOnly defaultStart, out TimeOnly defaultEnd))
                return;

            const string sql = @"
        UPDATE Staff
        SET FullName = @FullName, Phone = @Phone, DefaultStart = @DefaultStart, DefaultEnd = @DefaultEnd
        WHERE StaffId = @StaffId;";

            try
            {
                var rows = Db.Execute(sql, p =>
                {
                    p.Add("@FullName", SqlDbType.NVarChar, 255).Value = fullName;
                    p.Add("@Phone", SqlDbType.NVarChar, 255).Value = phone;
                    //p.Add("@[Role]", SqlDbType.VarChar, 255).Value = "Librarian";
                    p.Add("@DefaultStart", SqlDbType.Time).Value = defaultStart.ToTimeSpan();
                    p.Add("@DefaultEnd", SqlDbType.Time).Value = defaultEnd.ToTimeSpan();
                    p.Add("@StaffId", SqlDbType.Int).Value = staffId.Value;
                });

                if (rows == 0)
                {
                    MessageBox.Show("Không tìm thấy StaffId để cập nhật.");
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công!", "Thành công");
                    ReloadStaffFromDB();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa nhân viên thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            if (dataGridViewStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá.");
                return;
            }

            var q = MessageBox.Show(
                "Bạn có chắc muốn xoá nhân viên này không?\nLưu ý: Nếu nhân viên đã xử lý phiếu mượn hoặc có tài khoản, bạn không thể xoá!", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (q == DialogResult.No)
                return;

            try
            {
                using var conn = Db.Open();
                foreach (DataGridViewRow row in dataGridViewStaff.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        int id = Convert.ToInt32(drv.Row["Id"]);
                        using var cmd = new SqlCommand("DELETE FROM Staff WHERE StaffId = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xoá nhân viên thành công!", "Thành công");
                ReloadStaffFromDB();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint violation
                {
                    MessageBox.Show(
                        "Không thể xoá nhân viên này vì:\n" +
                        "- Đã xử lý phiếu mượn sách\n" +
                        "- Hoặc có tài khoản đăng nhập liên kết\n\n" +
                        "Vui lòng xử lý các dữ liệu liên quan trước.", "Lỗi");
                }
                else
                {
                    MessageBox.Show("Xoá thất bại:\n" + ex.Message, "Lỗi");
                }
            }
        }

        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridViewStaff.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;
                txtFullNameStaff.Text = r["FullName"]?.ToString() ?? "";
                txtPhoneStaff.Text = r["PhoneNumber"]?.ToString() ?? "";

                // Xử lý DefaultStart
                if (r["DefaultStart"] != DBNull.Value)
                {
                    TimeOnly startTime = TimeOnly.Parse(r["DefaultStart"].ToString());
                    dtpTimeStart.Value = DateTime.Today.Add(startTime.ToTimeSpan());
                }

                // Xử lý DefaultEnd
                if (r["DefaultEnd"] != DBNull.Value)
                {
                    TimeOnly endTime = TimeOnly.Parse(r["DefaultEnd"].ToString());
                    dtpTimeEnd.Value = DateTime.Today.Add(endTime.ToTimeSpan());
                }
                return;
            }

            txtFullNameStaff.Text = gridRow.Cells["FullName"]?.Value?.ToString() ?? "";
            txtPhoneStaff.Text = gridRow.Cells["Phone"]?.Value?.ToString() ?? "";

            if (gridRow.Cells["DefaultStart"]?.Value != null && gridRow.Cells["DefaultStart"].Value != DBNull.Value)
            {
                TimeOnly startTime = TimeOnly.Parse(gridRow.Cells["DefaultStart"].Value.ToString());
                dtpTimeStart.Value = DateTime.Today.Add(startTime.ToTimeSpan());
            }

            if (gridRow.Cells["DefaultEnd"]?.Value != null && gridRow.Cells["DefaultEnd"].Value != DBNull.Value)
            {
                TimeOnly endTime = TimeOnly.Parse(gridRow.Cells["DefaultEnd"].Value.ToString());
                dtpTimeEnd.Value = DateTime.Today.Add(endTime.ToTimeSpan());
            }
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            using (formRegister = new frmRegister())
            {
                formRegister.ShowDialog();
            }
        }
        #endregion
    }
}
