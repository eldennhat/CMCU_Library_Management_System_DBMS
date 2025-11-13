using Managment.Database;
using System.Data;
using System.Data.SqlClient;

namespace Managment.Forms
{
    public partial class frmRegister : Form
    {
        private int selectedAccountId = -1;

        private DataTable accountsTable;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadAccounts();
            LoadStaffComboBox();

        }

        private void LoadAccounts()
        {
            try
            {
                accountsTable = Db.Query(@"SELECT AccountId, Username, PasswordHash, Role, StaffId FROM Account ORDER BY AccountId");
                accountBindingSource.DataSource = accountsTable;
                dataGridViewAccount.DataSource = accountBindingSource;
                dataGridViewAccount.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách tài khoản:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStaffComboBox()
        {
            try
            {
                var staffDt = Db.Query(@"SELECT StaffId, FullName FROM Staff ORDER BY StaffId");
                cbStaffId.DataSource = staffDt;
                cbStaffId.DisplayMember = "FullName";
                cbStaffId.ValueMember = "StaffId";
                cbStaffId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách nhân viên:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.RowIndex >= dataGridViewAccount.Rows.Count) return;

            var selectedRow = dataGridViewAccount.Rows[e.RowIndex];
            if (selectedRow.DataBoundItem is DataRowView drv)
            {
                var row = drv.Row;

                selectedAccountId = Convert.ToInt32(row["AccountId"]);

                txtUsername.Text = row["Username"]?.ToString() ?? "";
                txtPasswordHash.Text = row["PasswordHash"]?.ToString() ?? "";

                string role = row["Role"]?.ToString() ?? "";
                cbRole.SelectedItem = role;

                if (role == "Admin" && row["StaffId"] == DBNull.Value)
                {
                    cbStaffId.SelectedIndex = -1;
                }
                else
                {
                    cbStaffId.SelectedValue = row["StaffId"];
                }
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPasswordHash.Text) || cbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập, mật khẩu và chọn chức vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPasswordHash.Clear();
            cbRole.SelectedIndex = -1;
            cbStaffId.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string username = txtUsername.Text.Trim();
            string passwordHash = txtPasswordHash.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
            int? staffId = null;

            if (role == "Librarian")
            {
                if (cbStaffId.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn ID Nhân viên cho Librarian.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                staffId = Convert.ToInt32(cbStaffId.SelectedValue);
            }

            const string sql = @"
                INSERT INTO Account (Username, PasswordHash, Role, StaffId)
                VALUES (@Username, @PasswordHash, @Role, @StaffId);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                    p.Add("@PasswordHash", SqlDbType.VarChar, 255).Value = passwordHash;
                    p.Add("@Role", SqlDbType.NVarChar, 50).Value = role;
                    p.Add("@StaffId", SqlDbType.Int).Value = (object)staffId ?? DBNull.Value;
                });

                ClearFields();
                LoadAccounts();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) // Duplicate key (username unique)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sửa tài khoản
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedAccountId == -1)
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            string username = txtUsername.Text.Trim();
            string passwordHash = txtPasswordHash.Text.Trim();
            string role = cbRole.SelectedItem.ToString();
            int? staffId = null;

            if (role == "Librarian")
            {
                if (cbStaffId.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn ID Nhân viên cho Librarian.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                staffId = Convert.ToInt32(cbStaffId.SelectedValue);
            }

            const string sql = @"
                UPDATE Account
                SET Username = @Username, PasswordHash = @PasswordHash, Role = @Role, StaffId = @StaffId
                WHERE AccountId = @AccountId;";

            try
            {
                int rowsAffected = Db.Execute(sql, p =>
                {
                    p.Add("@Username", SqlDbType.VarChar, 50).Value = username;
                    p.Add("@PasswordHash", SqlDbType.VarChar, 255).Value = passwordHash;
                    p.Add("@Role", SqlDbType.NVarChar, 50).Value = role;
                    p.Add("@StaffId", SqlDbType.Int).Value = (object)staffId ?? DBNull.Value;
                    p.Add("@AccountId", SqlDbType.Int).Value = selectedAccountId;
                });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    selectedAccountId = -1;
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedAccountId == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            const string sql = "DELETE FROM Account WHERE AccountId = @AccountId;";

            try
            {
                int rowsAffected = Db.Execute(sql, p =>
                {
                    p.Add("@AccountId", SqlDbType.Int).Value = selectedAccountId;
                });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    selectedAccountId = -1;
                    LoadAccounts();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // FK violation (nếu account liên kết với dữ liệu khác)
                {
                    MessageBox.Show("Không thể xóa vì tài khoản này đang được sử dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
