using LibraryManager.InitFile;
using LibraryManager.Models.Other;
using Newtonsoft.Json;
using System.Diagnostics.Eventing.Reader;

namespace LibraryManager.Forms
{
    /// <summary>
    /// Form đăng nhập đăng ký
    /// </summary>
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        #region Helpers
        private void LoadData()
        {
            string filePath = Path.Combine(PathStrings.folderPath, PathStrings.accountFileName);
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                var users = JsonConvert.DeserializeObject<List<RegisterUser>>(jsonData);
                if (users != null)
                {
                    foreach (var user in users)
                    {
                        registerUserBindingSource.Add(user);
                    }
                }
            }
        }
        #endregion

        #region Events
        private void frmRegister_Load(object sender, EventArgs e)
        {
            InitDirectory.autoPathCreator();
            LoadData();
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserRegister.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassRegister.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbRoleRegister.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPhoneRegister.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                registerUserBindingSource.Add(new RegisterUser
                {
                    id = registerUserBindingSource.Count,
                    username = txtUserRegister.Text,
                    password = txtPassRegister.Text,
                    role = cbRoleRegister.SelectedItem.ToString(),
                    phoneNumber = txtPhoneRegister.Text,
                });
                string filePath = Path.Combine(PathStrings.folderPath, PathStrings.accountFileName);
                File.WriteAllText(filePath, JsonConvert.SerializeObject(registerUserBindingSource));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserLogin.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtPassLogin.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbRoleLogin.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inputUsername = txtUserLogin.Text.Trim();
            string inputPassword = txtPassLogin.Text;
            string inputRole = cbRoleLogin.SelectedItem.ToString();

            string filePath = Path.Combine(PathStrings.folderPath, PathStrings.accountFileName);
            var accountsData = File.ReadAllText(filePath);
            var accounts = JsonConvert.DeserializeObject<List<RegisterUser>>(accountsData);

            var user = accounts.FirstOrDefault(a =>
            a.username.Equals(inputUsername, StringComparison.OrdinalIgnoreCase) &&
            a.password == inputPassword &&
            a.role == inputRole);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmMain().Show();

                /*var result = MessageBox.Show("Bạn có muốn ẩn form đăng nhập không?", "Hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)*/
                Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu hoặc chức vụ không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
