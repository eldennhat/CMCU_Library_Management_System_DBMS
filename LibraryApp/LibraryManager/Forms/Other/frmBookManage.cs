using LibraryManager.Forms.BookManage;
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
    /// Form gộp chung các chức năng quản lý sách
    /// </summary>
    public partial class frmBookManage : Form
    {
        public frmBookManage()
        {
            InitializeComponent();
        }

        private frmBookManagment frmBookManagment;

        private frmBookCopyManagment frmBookCopyManagment;

        #region Events
        private void frmBookManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng quản lý sách?. Nếu đồng ý sẽ đóng quản lý sách và bản sao sách", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        #endregion


        private void btnBook_Click(object sender, EventArgs e)
        {
            if (frmBookManagment == null || frmBookManagment.IsDisposed)
            {
                frmBookManagment = new frmBookManagment();
                frmBookManagment.Owner = this;
                frmBookManagment.Show();
            }
            else
                frmBookManagment.Activate();
        }

        private void btnBookCopy_Click(object sender, EventArgs e)
        {
            if (frmBookCopyManagment == null || frmBookCopyManagment.IsDisposed)
            {
                frmBookCopyManagment = new frmBookCopyManagment();
                frmBookCopyManagment.Owner = this;
                frmBookCopyManagment.Show();
            }
            else
                frmBookCopyManagment.Activate();
        }
    }
}