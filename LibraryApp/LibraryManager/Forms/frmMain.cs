using LibraryManager.Forms.Other;
using LibraryManager.Forms.Reader;
using LibraryManager.Forms.Staff;
using LibraryManager.InitFolder;

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
        }

        private frmBookManage bookManageForm;

        private frmBorrowPayback borrowPaybackForm;

        private frmReaderManagment readerManagmentForm;

        private frmStaffManagment staffManagmentForm;

        public string UserRole { get; set; }

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
            Create.InitFolder();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        #endregion

        #region Helpers
        private void ApplyRolePermissions()
        {
            if (UserRole == "Librarian") btnStaffManagment.Enabled = false;
        }
        #endregion

        private void btnBookManagement_Click(object sender, EventArgs e)
        {
            if (bookManageForm == null || bookManageForm.IsDisposed)
            {
                bookManageForm = new frmBookManage();
                bookManageForm.Owner = this;
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
                borrowPaybackForm.Owner = this;
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
                readerManagmentForm.Owner = this;
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
                staffManagmentForm.Owner = this;
                staffManagmentForm.Show();
            }
            else
                staffManagmentForm.Activate();
        }  
    }
}
