using LibraryManager.Infrastructure;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManager.Forms.BookManage
{
    /// <summary>
    /// Quản lý bản sao đầu sách
    /// </summary>
    public partial class frmBookCopyManagment : Form
    {
        private DataTable _bookCopies = new DataTable();

        public frmBookCopyManagment()
        {
            InitializeComponent();
        }

        #region Events
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridView1.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            // Xử lý DataRowView (từ DataTable)
            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;

                // Set BookId cho ComboBox
                if (r["BookId"] != DBNull.Value)
                    cbIDBook.SelectedValue = Convert.ToInt32(r["BookId"]);
                else
                    cbIDBook.SelectedIndex = -1;

                // Set các TextBox
                txtBarCode.Text = r["Barcode"]?.ToString() ?? "";
                txtStorageNote.Text = r["StorageNote"]?.ToString() ?? "";
                txtBookMoney.Text = r["BookMoney"]?.ToString() ?? "";
                txtPublisher.Text = r["PublisherName"]?.ToString() ?? "";

                // Set Status ComboBox - chuyển từ giá trị DB sang index
                if (r["Status"] != DBNull.Value)
                {
                    int statusVal = Convert.ToInt32(r["Status"]);
                    switch (statusVal)
                    {
                        case -1: cbStatus.SelectedIndex = 0; break; // Lost
                        case 0: cbStatus.SelectedIndex = 1; break;  // Available
                        case 1: cbStatus.SelectedIndex = 2; break;  // OnLoan
                        case 2: cbStatus.SelectedIndex = 3; break;  // Damaged
                        default: cbStatus.SelectedIndex = 1; break;  // Mặc định Available
                    }
                }
                return;
            }
        }

        private void frmBookCopyManagment_Load(object sender, EventArgs e)
        {
            LoadBookList();
            LoadStatusList();
            ReloadFromDB();
        }
        #endregion

        #region Helpers
        public void RefreshBookList()
        {
            LoadBookList();
        }


        private void LoadBookList()
        {
            try
            {
                // Lấy danh sách Book từ DB
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

        private void LoadStatusList()
        {
            // Xóa items cũ và thêm lại đúng
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Lost");      // index 0 -> value -1
            cbStatus.Items.Add("Available"); // index 1 -> value 0
            cbStatus.Items.Add("OnLoan");    // index 2 -> value 1
            cbStatus.Items.Add("Damaged");   // index 3 -> value 2
            cbStatus.SelectedIndex = 1; // Mặc định là Available
        }

        private bool TryGetInputs(out int bookId, out string barcode, out string storagenote,
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

        private void ReloadFromDB()
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
            if (dataGridView1.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["CopyId"]);
            return null;
        }
        #endregion 

        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out int bookId, out string barcode, out string storagenote, out decimal bookmoney, out string publisher, out int statusValue))
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

                ReloadFromDB();

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[0].Selected = true;
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

            if (!TryGetInputs(out int bookId, out string barcode, out string storagenote,
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

                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa bản sao sách thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnDeleteBookCopy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn ít nhất một dòng để xoá.");
                return;
            }

            try
            {
                using var conn = Db.Open();
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        int id = Convert.ToInt32(drv.Row["CopyId"]);
                        using var cmd = new SqlCommand("DELETE FROM BookCopy WHERE CopyId=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnDeleteAllBookCopy_Click(object sender, EventArgs e)
        {
            if (bookCopyBindingSource.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.", "Thông báo");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xoá tất cả bản sao sách không? Hành động này không thể hoàn tác !!!",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.No)
                return;

            try
            {
                Db.Execute("DELETE FROM BookCopy");
                MessageBox.Show("Xoá tất cả thành công!", "Thông báo");
                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá tất cả thất bại:\n" + ex.Message, "Lỗi");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            RefreshBookList();
        }
    }
}
