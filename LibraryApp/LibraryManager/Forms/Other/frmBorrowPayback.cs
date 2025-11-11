using LibraryManager.Forms.BorrowPayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Forms.Other
{
    /// <summary>
    /// Form gộp chung các form mượn trả sách
    /// </summary>
    public partial class frmBorrowPayback : Form
    {
        public frmBorrowPayback()
        {
            InitializeComponent();
        }

        private frmLoanManagment frmLoanManagment;

        private frmLoanDetailsManagment frmLoanDetailsManagment;

        #region Events
        private void frmBorrowPayback_FormClosing(object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng quản mượn/trả sách?. Nếu đồng ý sẽ đóng quản lý sách và bản sao sách", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        #endregion

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (frmLoanManagment == null || frmLoanManagment.IsDisposed)
            {
                frmLoanManagment = new frmLoanManagment();
                frmLoanManagment.Owner = this;
                frmLoanManagment.Show();
            }
            else
                frmLoanManagment.Activate();
        }

        private void btnLoanDetails_Click(object sender, EventArgs e)
        {
            if (frmLoanDetailsManagment == null || frmLoanDetailsManagment.IsDisposed)
            {
                frmLoanDetailsManagment = new frmLoanDetailsManagment();
                frmLoanDetailsManagment.Owner= this;
                frmLoanDetailsManagment.Show();
            }
            else
                frmLoanDetailsManagment.Activate();
        }
    }
}
