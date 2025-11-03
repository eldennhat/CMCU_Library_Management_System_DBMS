using LibraryManager.Forms.BasicDirectory;
using LibraryManager.Forms.BookManage;
using LibraryManager.Forms.BorrowPayback;
using LibraryManager.Forms.Other;
using LibraryManager.Forms.Reader;
using LibraryManager.Forms.Setplace;
using LibraryManager.Forms.Staff;
using LibraryManager.Models;
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
        }

        private frmBasicDirectory basicDirectoryForm;

        private frmBookManage bookManageForm;

        private frmBorrowPayback borrowPaybackForm;

        private frmReaderManagment readerManagmentForm;

        private frmStaffManagment staffManagmentForm;

        private frmReservationManagment reservationManagmentForm;

        public string UserRole { get; set; }

        #region Events
        private void frmMain_Load(object sender, EventArgs e)
        {
            ApplyRolePermissions();
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
        }
        #endregion

        #region Helpers
        private void ApplyRolePermissions()
        {
            if (UserRole == "Librarian") btnStaffManagment.Enabled = false;
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
    }
}
