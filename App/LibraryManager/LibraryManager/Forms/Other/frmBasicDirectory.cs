using LibraryManager.Forms.BasicDirectory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Forms.Other
{
    /// <summary>
    /// Form gộp chung các danh mục cơ bản
    /// </summary>
    public partial class frmBasicDirectory : Form
    {
        public frmBasicDirectory()
        {
            InitializeComponent();
        }

        private frmAuthorManagment authorForm = null;

        private frmCategoryManagment categoryForm = null;

        private frmPublisherManagment publisherForm = null;

        #region Events
        private void frmBasicDirectory_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Đóng cửa sổ quản lý danh mục cơ bản sẽ đồng thời đóng tất cả các cửa sổ quản lý danh mục con. Bạn có chắc chắn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            CloseSubForm();
        }
        #endregion

        #region Helpers
        private void CloseSubForm()
        {
            var children = new Form[] { authorForm, categoryForm, publisherForm };
            foreach (var f in children)
            {
                if (f != null && !f.IsDisposed)
                    f.Close();
            }
        }
        #endregion

        private void btnAuthorManagment_Click(object sender, EventArgs e)
        {
            if (authorForm == null || authorForm.IsDisposed)
            {
                authorForm = new frmAuthorManagment();
                authorForm.Show();
            }
            else
                authorForm.Activate();
        }

        private void btnCategoryManagment_Click(object sender, EventArgs e)
        {
            if (categoryForm == null || categoryForm.IsDisposed)
            {
                categoryForm = new frmCategoryManagment();
                categoryForm.Show();
            }
            else
                categoryForm.Activate();
        }

        private void btnPublisherManagment_Click(object sender, EventArgs e)
        {
            if (publisherForm == null || publisherForm.IsDisposed)
            {
                publisherForm = new frmPublisherManagment();
                publisherForm.Show();
            }
            else
                publisherForm.Activate();
        }

        
    }
}
