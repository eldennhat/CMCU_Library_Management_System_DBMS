using LibraryManager.Forms.Other;
using LibraryManager.Forms.Reader;
using LibraryManager.Forms.Staff;
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

namespace LibraryManager.Forms
{
    /// <summary>
    /// Điều hướng tới các form chính
    /// </summary>
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitializeConnectionOptions();
        }

        #region Events
        private void cbWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWindowsAuthentication.Checked)
            {
                cbSQLServerAuthentication.Enabled = false;

                SetWindowsAuthControlsEnabled(true);
                SetSQLServerAuthControlsEnabled(false);
            }
            else
            {
                cbSQLServerAuthentication.Enabled = true;

                SetWindowsAuthControlsEnabled(false);
            }
        }

        private void cbSQLServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSQLServerAuthentication.Checked)
            {
                cbWindowsAuthentication.Enabled = false;

                SetSQLServerAuthControlsEnabled(true);
                SetWindowsAuthControlsEnabled(false);
            }
            else
            {
                cbWindowsAuthentication.Enabled = true;

                SetSQLServerAuthControlsEnabled(false);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            if (!string.IsNullOrEmpty(ConnectionString))
                ConnectionString = null;
        }
        #endregion

        #region Helpers
        private void InitializeConnectionOptions()
        {
            SetWindowsAuthControlsEnabled(false);
            SetSQLServerAuthControlsEnabled(false);
        }

        private void SetWindowsAuthControlsEnabled(bool enabled)
        {
            label1.Enabled = enabled;
            txtNameSVWindowsAuth.Enabled = enabled;
            btnConnectDBWindowsAuthentication.Enabled = enabled;
        }

        private void SetSQLServerAuthControlsEnabled(bool enabled)
        {
            label3.Enabled = enabled;
            txtNameSVSQLServerAuth.Enabled = enabled;
            label4.Enabled = enabled;
            txtUserSQLServerAuth.Enabled = enabled;
            label5.Enabled = enabled;
            txtPassSQLServerAuth.Enabled = enabled;
            btnConnectDBSQLServerAuthentication.Enabled = enabled;
        }
        #endregion

        private void btnBasicDirectory_Click(object sender, EventArgs e)
        {
            new frmBasicDirectory().Show();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            new frmBookManage().Show();
        }

        private void btnBorrowPayback_Click(object sender, EventArgs e)
        {
            new frmBorrowPayback().Show();
        }

        private void btnReaderMangment_Click(object sender, EventArgs e)
        {
            new frmReaderManagment().Show();
        }

        private void btnStaffManagment_Click(object sender, EventArgs e)
        {
            new frmStaffManagment().Show();
        }

        private void btnSetplace_Click(object sender, EventArgs e)
        {
            new frmStaffManagment().Show();
        }

        public string ConnectionString { get; set; }

        private async void btnConnectDBWindowsAuthentication_Click(object sender, EventArgs e)
        {
            var server = txtNameSVWindowsAuth.Text.Trim();
            if (string.IsNullOrWhiteSpace(server))
            {
                MessageBox.Show("Vui lòng nhập Server Name.");
                return;
            }

            ConnectionString = $"Data Source={server};Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True";

            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    MessageBox.Show("Kết nối thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kết nối thất bại:\n" + ex.Message);
                }
            }
        }

        private async void btnConnectDBSQLServerAuthentication_Click(object sender, EventArgs e)
        {
            var server = txtNameSVSQLServerAuth.Text.Trim();
            if (string.IsNullOrWhiteSpace(server))
            {
                MessageBox.Show("Vui lòng nhập Server Name.");
                return;
            }


            var user = txtUserSQLServerAuth.Text.Trim();
            var pass = txtPassSQLServerAuth.Text;
            ConnectionString = $"Data Source={server};Initial Catalog=LibraryDB;User ID={user};Password={pass};TrustServerCertificate=True";

            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    MessageBox.Show("Kết nối thành công!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kết nối thất bại:\n" + ex.Message);
                }
            }
        }
    }
}
