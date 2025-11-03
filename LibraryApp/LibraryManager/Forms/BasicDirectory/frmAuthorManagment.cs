using LibraryManager.InitFile;
using LibraryManager.Models.Other;
using LibraryManager.Models.Sub;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager.Forms.BasicDirectory
{
    /// <summary>
    /// Quản lý tác giả
    /// </summary>
    public partial class frmAuthorManagment : Form
    {
        public frmAuthorManagment()
        {
            InitializeComponent();
        }

        #region Events
        private void frmAuthorManagment_Load(object sender, EventArgs e)
        {
            LoadAuthorData();
        }
        #endregion

        #region Helpers
        private void LoadAuthorData()
        {
            string filePath = Path.Combine(PathStrings.folderPath, PathStrings.authorFileName);
            if (File.Exists(filePath))
            {
                var authors = JsonConvert.DeserializeObject<List<Author>>(File.ReadAllText(filePath));
                authorBindingSource.DataSource = authors;
            }
            else
            {
                authorBindingSource.DataSource = new List<Author>();
            }
        }

        #endregion

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAuthorName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAuthorPenName.Text))
            {
                MessageBox.Show("Vui lòng nhập bút danh tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtAuthorPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại tác giả.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            authorBindingSource.Add(new Author(authorBindingSource.Count, txtAuthorName.Text,
                                    txtAuthorPenName.Text, txtAuthorPhoneNumber.Text));

            string filePath = Path.Combine(PathStrings.folderPath, PathStrings.authorFileName);
            File.WriteAllText(filePath, JsonConvert.SerializeObject(authorBindingSource));

        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {

        } 
    }
}
