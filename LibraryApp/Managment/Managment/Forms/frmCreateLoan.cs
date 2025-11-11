using Managment.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Managment.Forms
{
    public partial class frmCreateLoan : Form
    {
        public frmCreateLoan()
        {
            InitializeComponent();
            LoadReaders();
            LoadStaffs();
            LoadAvailableBooks();
        }

        private void LoadReaders()
        {
            try
            {
                var dt = Db.Query("SELECT ReaderId, FullName, Phone FROM Reader ORDER BY FullName");
                cbReader.DataSource = dt;
                cbReader.DisplayMember = "FullName";
                cbReader.ValueMember = "ReaderId";
                cbReader.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách độc giả:\n" + ex.Message, "Lỗi");
            }
        }

        private void LoadStaffs()
        {
            try
            {
                var dt = Db.Query("SELECT StaffId, FullName FROM Staff ORDER BY FullName");
                cbStaff.DataSource = dt;
                cbStaff.DisplayMember = "FullName";
                cbStaff.ValueMember = "StaffId";
                cbStaff.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhân viên:\n" + ex.Message, "Lỗi");
            }
        }

        private void LoadAvailableBooks()
        {
            try
            {
                // Chỉ lấy sách có Status = 0 (Available)
                var dt = Db.Query(@"
                    SELECT 
                        bc.CopyId,
                        b.Title + ' (' + bc.Barcode + ')' AS DisplayText,
                        bc.BookMoney
                    FROM BookCopy bc
                    INNER JOIN Book b ON bc.BookId = b.BookId
                    WHERE bc.Status = 0
                    ORDER BY b.Title
                ");

                cbBookCopy.DataSource = dt;
                cbBookCopy.DisplayMember = "DisplayText";
                cbBookCopy.ValueMember = "CopyId";
                cbBookCopy.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách sách khả dụng:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (cbReader.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbStaff.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbBookCopy.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sách.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int readerId = Convert.ToInt32(cbReader.SelectedValue);
            int staffId = Convert.ToInt32(cbStaff.SelectedValue);
            int copyId = Convert.ToInt32(cbBookCopy.SelectedValue);
            DateTime loanDate = dtpLoanDate.Value;
            DateTime dueDate = dtpDueDate.Value;
            string note = txtNote.Text.Trim();

            // Validate dates
            if (dueDate <= loanDate)
            {
                MessageBox.Show("Ngày hẹn trả phải sau ngày mượn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giá sách để tính tiền cọc
            decimal bookMoney = 0;
            var bookCopyRow = (cbBookCopy.DataSource as DataTable)?.Select($"CopyId = {copyId}");
            if (bookCopyRow != null && bookCopyRow.Length > 0)
            {
                bookMoney = Convert.ToDecimal(bookCopyRow[0]["BookMoney"]);
            }

            decimal deposit = bookMoney * 2; // Tiền cọc = 2 lần giá sách

            using (var conn = Db.Open())
            using (var transaction = conn.BeginTransaction())
            {
                try
                {
                    // 1. Tạo Loan
                    const string sqlLoan = @"
                        INSERT INTO Loan (ReaderId, StaffId, LoanDate, DueDate, Note)
                        OUTPUT INSERTED.LoanId
                        VALUES (@ReaderId, @StaffId, @LoanDate, @DueDate, @Note);
                    ";

                    int loanId;
                    using (var cmdLoan = new SqlCommand(sqlLoan, conn, transaction))
                    {
                        cmdLoan.Parameters.AddWithValue("@ReaderId", readerId);
                        cmdLoan.Parameters.AddWithValue("@StaffId", staffId);
                        cmdLoan.Parameters.AddWithValue("@LoanDate", loanDate);
                        cmdLoan.Parameters.AddWithValue("@DueDate", dueDate);
                        cmdLoan.Parameters.AddWithValue("@Note", (object?)note ?? DBNull.Value);
                        loanId = (int)cmdLoan.ExecuteScalar();
                    }

                    // 2. Tạo LoanDetail
                    const string sqlLoanDetail = @"
                        INSERT INTO LoanDetail (LoanId, CopyId, Deposit)
                        VALUES (@LoanId, @CopyId, @Deposit);
                    ";

                    using (var cmdDetail = new SqlCommand(sqlLoanDetail, conn, transaction))
                    {
                        cmdDetail.Parameters.AddWithValue("@LoanId", loanId);
                        cmdDetail.Parameters.AddWithValue("@CopyId", copyId);
                        cmdDetail.Parameters.AddWithValue("@Deposit", deposit);
                        cmdDetail.ExecuteNonQuery();
                    }

                    // 3. Cập nhật Status của BookCopy sang OnLoan (1)
                    const string sqlUpdateStatus = @"
                        UPDATE BookCopy
                        SET Status = 1
                        WHERE CopyId = @CopyId;
                    ";

                    using (var cmdStatus = new SqlCommand(sqlUpdateStatus, conn, transaction))
                    {
                        cmdStatus.Parameters.AddWithValue("@CopyId", copyId);
                        cmdStatus.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show(
                        $"Tạo phiếu mượn thành công!\n\nMã phiếu: {loanId}\nTiền cọc: {deposit:N0} VNĐ",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Tạo phiếu mượn thất bại:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}