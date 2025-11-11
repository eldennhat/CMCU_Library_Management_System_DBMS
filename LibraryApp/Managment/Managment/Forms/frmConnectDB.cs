using Managment.Database;
using System.Data.SqlClient;

namespace Managment.Forms
{
    public partial class frmConnectDB : Form
    {
        public frmConnectDB()
        {
            InitializeComponent();
            InitializeConnectionOptions();
        }

        #region Helpers
        private void InitializeConnectionOptions()
        {
            SetWindowsAuthControlsEnabled(false);
            SetSQLServerAuthControlsEnabled(false);
        }

        private void SetWindowsAuthControlsEnabled(bool enabled)
        {
            lbConnectWindowsAuthen.Enabled = enabled;
            txtConnectWindowsAuthent.Enabled = enabled;
            btnConnectWindowsAuthen.Enabled = enabled;
        }

        private void SetSQLServerAuthControlsEnabled(bool enabled)
        {
            label2.Enabled = enabled;
            txtServerSQLAuthen.Enabled = enabled;
            label3.Enabled = enabled;
            txtUsernameSQLAuthen.Enabled = enabled;
            label4.Enabled = enabled;
            txtPasswordSQLAuthen.Enabled = enabled;
            btnConnectSQLAuthen.Enabled = enabled;
        }
        #endregion

        private void cbConnectWindowsAuthen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConnectWindowsAuthen.Checked)
            {
                cbConnectSQLAuthen.Enabled = false;
                SetWindowsAuthControlsEnabled(true);
                SetSQLServerAuthControlsEnabled(false);
            }
            else
            {
                cbConnectSQLAuthen.Enabled = true;
                SetSQLServerAuthControlsEnabled(true);
            }
        }

        private void cbConnectSQLAuthen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbConnectSQLAuthen.Checked)
            {
                cbConnectWindowsAuthen.Enabled = false;
                SetSQLServerAuthControlsEnabled(true);
                SetWindowsAuthControlsEnabled(false);
            }
            else
            {
                cbConnectWindowsAuthen.Enabled = true;
                SetWindowsAuthControlsEnabled(true);
            }
        }

        public string ConnectionString { get; set; }

        private async void btnConnectWindowsAuthen_Click(object sender, EventArgs e)
        {
            var server = txtConnectWindowsAuthent.Text.Trim();
            if (string.IsNullOrWhiteSpace(server))
            {
                MessageBox.Show("Vui lòng nhập Server Name.");
                return;
            }

            ConnectionString = $"Data Source={server};Initial Catalog=LibraryDB;Integrated Security=True;TrustServerCertificate=True;";

            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    MessageBox.Show("Kết nối thành công!");
                    AppSession.ConnectionString = ConnectionString;
                    var loginForm = new frmLogin();
                    loginForm.Show();
                    Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kết nối thất bại:\n" + ex.Message);
                }
            }
        }

        private async void btnConnectSQLAuthen_Click(object sender, EventArgs e)
        {
            var server = txtPasswordSQLAuthen.Text.Trim();
            if (string.IsNullOrWhiteSpace(server))
            {
                MessageBox.Show("Vui lòng nhập Server Name.");
                return;
            }


            var user = txtUsernameSQLAuthen.Text.Trim();
            var pass = txtPasswordSQLAuthen.Text;

            ConnectionString = $"Data Source={server};Initial Catalog=LibraryDB;User ID={user};Password={pass};TrustServerCertificate=True";

            using (var conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    MessageBox.Show("Kết nối thành công!");
                    AppSession.ConnectionString = ConnectionString;
                    var loginForm = new frmLogin();
                    loginForm.Show();
                    Hide();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kết nối thất bại:\n" + ex.Message);
                }
            }
        }
    }
}
