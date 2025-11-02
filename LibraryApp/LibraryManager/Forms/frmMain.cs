using LibraryManager.Forms.BasicDirectory;
using LibraryManager.Forms.BookManage;
using LibraryManager.Forms.BorrowPayback;
using LibraryManager.Forms.Other;
using LibraryManager.Forms.Reader;
using LibraryManager.Forms.Setplace;
using LibraryManager.Forms.Staff;
using System.Data.SqlClient;

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

        private frmBasicDirectory basicDirectoryForm;

        private frmAuthorManagment authorManagmentForm;

        private frmCategoryManagment categoryManagmentForm;

        private frmPublisherManagment publisherManagmentForm;

        private frmBookManage bookManageForm;

        private frmBookCopyManagment bookCopyManagmentForm;

        private frmBookManagment bookManagmentForm;

        private frmBorrowPayback borrowPaybackForm;

        private frmLoanHistory loanHistoryForm;

        private frmLoanManagment loanManagmentForm;

        private frmReturnManagment returnManagmentForm;

        private frmReaderManagment readerManagmentForm;

        private frmStaffManagment staffManagmentForm;

        private frmReservationManagment reservationManagmentForm;

        public string ConnectionString { get; set; }

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
            CloseAllForms();
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

        private void CloseAllForms()
        {
            var openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (var f in openForms)
            {
                if (f != this && !f.IsDisposed)
                    f.Close();
            }
        }
        #endregion

        private void btnBasicDirectory_Click(object sender, EventArgs e)
        {
            if (basicDirectoryForm == null || basicDirectoryForm.IsDisposed)
            {
                basicDirectoryForm = new frmBasicDirectory();
                basicDirectoryForm.Show();
            }
            else
                basicDirectoryForm.Activate();
        }

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            if (bookManageForm == null || bookManageForm.IsDisposed)
            {
                bookManageForm = new frmBookManage();
                bookManageForm.Show();
            }
            else
                bookManageForm.Activate();
        }

        private void btnBorrowPayback_Click(object sender, EventArgs e)
        {
            if (borrowPaybackForm == null || borrowPaybackForm.IsDisposed)
            {
                borrowPaybackForm = new frmBorrowPayback();
                borrowPaybackForm.Show();
            }
            else
                borrowPaybackForm.Activate();
        }

        private void btnReaderMangment_Click(object sender, EventArgs e)
        {
            if (readerManagmentForm == null || readerManagmentForm.IsDisposed)
            {
                readerManagmentForm = new frmReaderManagment();
                readerManagmentForm.Show();
            }
            else
                readerManagmentForm.Activate();
        }

        private void btnStaffManagment_Click(object sender, EventArgs e)
        {
            if (staffManagmentForm == null || staffManagmentForm.IsDisposed)
            {
                staffManagmentForm = new frmStaffManagment();
                staffManagmentForm.Show();
            }
            else
                staffManagmentForm.Activate();
        }

        private void btnSetplace_Click(object sender, EventArgs e)
        {
            if (reservationManagmentForm == null || reservationManagmentForm.IsDisposed)
            {
                reservationManagmentForm = new frmReservationManagment();
                reservationManagmentForm.Show();
            }
            else
                reservationManagmentForm.Activate();
        }

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
