using LibraryManager.Models.Other;
using System.Data.SqlClient;

namespace LibraryManager.Forms
{
    /// <summary>
    /// Form đăng nhập
    /// </summary>
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Events
        private void frmRegister_Load(object sender, EventArgs e)
        {
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserLogin.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassLogin.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRole = cbRoleLogin.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(AppSession.ConnectionString))
            {
                MessageBox.Show("Chưa có chuỗi kết nối. Hãy kết nối CSDL trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var username = txtUserLogin.Text.Trim();
            var password = txtPassLogin.Text;

            var sql = selectedRole == null
                ? "SELECT [Role] FROM Account WHERE Username = @u AND PasswordHash = @p"
                : "SELECT [Role] FROM Account WHERE Username = @u AND PasswordHash = @p AND [Role] = @r";

            using (var conn = new SqlConnection(AppSession.ConnectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                if (selectedRole != null)
                    cmd.Parameters.AddWithValue("@r", selectedRole);

                try
                {
                    conn.Open();
                    var roleFromDb = cmd.ExecuteScalar() as string;

                    if (!string.IsNullOrEmpty(roleFromDb))
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var mainForm = new frmMain
                        {
                            UserRole = roleFromDb // "Admin" hoặc "Librarian"
                        };
                        mainForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng (hoặc sai vai trò).", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi khi đăng nhập:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerUserBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
