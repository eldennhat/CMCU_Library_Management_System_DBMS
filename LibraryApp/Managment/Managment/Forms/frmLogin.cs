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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAcc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRole = cbRole.SelectedItem?.ToString();

            if (selectedRole == null || selectedRole != cbRole.SelectedItem?.ToString())
            {
                MessageBox.Show("Vui lòng chọn chức vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    


            if (string.IsNullOrWhiteSpace(AppSession.ConnectionString))
            {
                MessageBox.Show("Chưa kết nối. Hãy kết nối CSDL trước.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var username = txtAcc.Text.Trim();
            var password = txtPass.Text;

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
    }
}
