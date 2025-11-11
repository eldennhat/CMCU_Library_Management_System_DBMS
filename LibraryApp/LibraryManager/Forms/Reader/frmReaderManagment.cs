using LibraryManager.Infrastructure;
using LibraryManager.Models.BookManage;
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

namespace LibraryManager.Forms.Reader
{
    /// <summary>
    /// Quản lý độc giả
    /// </summary>
    public partial class frmReaderManagment : Form
    {
        public frmReaderManagment()
        {
            InitializeComponent();
        }

        private DataTable _Readers = new DataTable();

        #region Helpers
        public void ReloadFromDB()
        {
            try
            {
                try
                {
                    _Readers = Db.Query(@"
                    SELECT 
                        r.ReaderId,
                        r.FullName,
                        r.Phone,
                        r.Address,
                        r.CreateAt,
                        r.Fine,
                        r.Deposit
                    FROM Reader r
                    ORDER BY r.ReaderId");

                    readerBindingSource.DataSource = _Readers;
                    readerBindingSource.ResetBindings(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tải được dữ liệu BookCopy từ SQL:\n" + ex.Message, "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu Book từ SQL:\n" + ex.Message, "Lỗi");
            }
        }

        private bool TryGetInputs(out string fullname, out string phone, out string address, out decimal fine)
        {
            fullname = txtFullNameReader.Text.Trim();
            phone = txtPhoneNumberReader.Text.Trim();
            address = txtAddressReader.Text.Trim();
            fine = -1;

            if (string.IsNullOrWhiteSpace(fullname) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Tên người đọc, Số điện thoại, Địa chỉ không được để trống.");
                return false;
            }
            
            return true;
        }
        #endregion

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out string fullname, out string phone, out string address, out decimal fine))
                return;

            const string sql = @"
            INSERT INTO Reader (FullName, Phone, Address, Fine)
            VALUES (@FullName, @Phone, @Address, @Fine);";

            try
            {
                Db.Execute(sql, p =>
                {
                    p.Add("@FullName", SqlDbType.NVarChar, 255).Value = (object?)fullname ?? DBNull.Value;
                    p.Add("@Phone", SqlDbType.NVarChar, 255).Value = (object?)phone ?? DBNull.Value;
                    p.Add("@Address", SqlDbType.NVarChar, 255).Value = (object?)address ?? DBNull.Value;
                    p.Add("@Fine", SqlDbType.Decimal).Value = (object?)fine ?? DBNull.Value;
                    //p.Add("@Deposit", SqlDbType.Decimal).Value = (object?)deposit ?? DBNull.Value
                });
                ReloadFromDB();
                dataGridView1.ClearSelection();
                if (dataGridView1.Rows.Count > 0) dataGridView1.Rows[0].Selected = true; // select hàng mới nhất
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thêm sách thất bại:\n" + ex.Message);
            }
        }

        private void btnEditReader_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteReader_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAllReader_Click(object sender, EventArgs e)
        {

        }
    }
}
