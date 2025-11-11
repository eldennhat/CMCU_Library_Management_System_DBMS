using LibraryManager.Infrastructure;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Forms.BookManage
{
    /// <summary>
    /// Quản lý đầu sách
    /// </summary>
    public partial class frmBookManagment : Form
    {
        private DataTable _books = new DataTable();

        public frmBookManagment()
        {
            InitializeComponent();
        }

        #region Events
        private void frmBookManagment_Load(object sender, EventArgs e)
        {
            // BookId chỉ đọc
            var colId = dataGridView1.Columns.Cast<DataGridViewColumn>()
                .FirstOrDefault(c => string.Equals(c.DataPropertyName, "BookId", StringComparison.OrdinalIgnoreCase));
            if (colId != null) colId.ReadOnly = true;

            ReloadFromDB();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var gridRow = dataGridView1.Rows[e.RowIndex];
            if (gridRow.IsNewRow) return;

            if (gridRow.DataBoundItem is DataRowView drv)
            {
                var r = drv.Row;
                txtISBNBook.Text = r["ISBN"]?.ToString() ?? "";
                txtTitleBook.Text = r["Title"]?.ToString() ?? "";
                txtCategoryName.Text = r["CategoryName"]?.ToString() ?? "";
                txtAuthorName.Text = r["BookAuthor"]?.ToString() ?? "";
                txtPublishYear.Text = r["PublishYear"]?.ToString() ?? "";
                return;
            }

            if (gridRow.DataBoundItem is LibraryManager.Models.BookManage.Book book)
            {
                txtISBNBook.Text = book.ISBN ?? "";
                txtTitleBook.Text = book.Title ?? "";
                txtCategoryName.Text = book.CategoryName ?? "";
                txtAuthorName.Text = book.BookAuthor ?? "";
                txtPublishYear.Text = book.PublishYear.ToString();
                return;
            }

            txtISBNBook.Text = gridRow.Cells["ISBN"]?.Value?.ToString() ?? "";
            txtTitleBook.Text = gridRow.Cells["Title"]?.Value?.ToString() ?? "";
            txtCategoryName.Text = gridRow.Cells["CategoryName"]?.Value?.ToString() ?? "";
            txtAuthorName.Text = gridRow.Cells["BookAuthor"]?.Value?.ToString() ?? "";
            txtPublishYear.Text = gridRow.Cells["PublishYear"]?.Value?.ToString() ?? "";
        }
        #endregion

        #region Helpers
        private void ReloadFromDB()
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

        private bool TryGetInputs(out string isbn, out string title, out string category, out string author, out int year)
        {
            isbn = txtISBNBook.Text.Trim();
            title = txtTitleBook.Text.Trim();
            category = txtCategoryName.Text.Trim();
            author = txtAuthorName.Text.Trim();

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

        private int? GetSelectedBookId()
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is DataRowView drv)
                return Convert.ToInt32(drv.Row["BookId"]);
            return null;
        }
        #endregion

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out var isbn, out var title, out var category, out var author, out var year))
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
                ReloadFromDB();
                dataGridView1.ClearSelection();
                if (dataGridView1.Rows.Count > 0) dataGridView1.Rows[0].Selected = true; // select hàng mới nhất
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
            if (!TryGetInputs(out var isbn, out var title, out var category, out var author, out var year))
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
                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Sửa sách thất bại:\n" + ex.Message);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
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
                        int id = Convert.ToInt32(drv.Row["BookId"]);
                        using var cmd = new SqlCommand("DELETE FROM Book WHERE BookId=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá thất bại:\n" + ex.Message);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xoá.", "Thông báo");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá tất cả dữ liệu khôn ?. Hành động này không thể hoàn tác !!!",
            "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
                return;

            try
            {
                Db.Execute("DELETE FROM Book");
                ReloadFromDB();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xoá tất cả thất bại:\n" + ex.Message);
            }
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {

        }
    }
}
