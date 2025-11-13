namespace Managment.Forms
{
    partial class frmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewAccount = new DataGridView();
            accountIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordHashDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            label1 = new Label();
            txtUsername = new TextBox();
            txtPasswordHash = new TextBox();
            label2 = new Label();
            cbRole = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbStaffId = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.AllowUserToAddRows = false;
            dataGridViewAccount.AllowUserToDeleteRows = false;
            dataGridViewAccount.AllowUserToResizeRows = false;
            dataGridViewAccount.AutoGenerateColumns = false;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Columns.AddRange(new DataGridViewColumn[] { accountIdDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordHashDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, staffIdDataGridViewTextBoxColumn });
            dataGridViewAccount.DataSource = accountBindingSource;
            dataGridViewAccount.Location = new Point(0, 0);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.ReadOnly = true;
            dataGridViewAccount.RowHeadersVisible = false;
            dataGridViewAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAccount.Size = new Size(403, 338);
            dataGridViewAccount.TabIndex = 0;
            dataGridViewAccount.CellClick += dataGridViewAccount_CellClick;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            accountIdDataGridViewTextBoxColumn.HeaderText = "ID Tài khoản";
            accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            accountIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordHashDataGridViewTextBoxColumn
            // 
            passwordHashDataGridViewTextBoxColumn.DataPropertyName = "PasswordHash";
            passwordHashDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            passwordHashDataGridViewTextBoxColumn.Name = "passwordHashDataGridViewTextBoxColumn";
            passwordHashDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            staffIdDataGridViewTextBoxColumn.HeaderText = "ID Nhân viên";
            staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            staffIdDataGridViewTextBoxColumn.ReadOnly = true;
            staffIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(Models.Account);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(533, 41);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(171, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPasswordHash
            // 
            txtPasswordHash.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordHash.Location = new Point(533, 75);
            txtPasswordHash.Name = "txtPasswordHash";
            txtPasswordHash.Size = new Size(114, 23);
            txtPasswordHash.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 79);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbRole.Location = new Point(533, 109);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(89, 23);
            cbRole.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(476, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Chức vụ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 147);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "ID Nhân viên";
            // 
            // cbStaffId
            // 
            cbStaffId.FormattingEnabled = true;
            cbStaffId.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbStaffId.Location = new Point(533, 143);
            cbStaffId.Name = "cbStaffId";
            cbStaffId.Size = new Size(156, 23);
            cbStaffId.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(450, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(547, 200);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(645, 200);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Xoá";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(757, 338);
            Controls.Add(btnRemove);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(cbStaffId);
            Controls.Add(label3);
            Controls.Add(cbRole);
            Controls.Add(txtPasswordHash);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(dataGridViewAccount);
            MaximizeBox = false;
            Name = "frmRegister";
            Text = "frmRegister";
            Load += frmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewAccount;
        private DataGridViewTextBoxColumn accountIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordHashDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPasswordHash;
        private Label label2;
        private ComboBox cbRole;
        private Label label3;
        private Label label4;
        private ComboBox cbStaffId;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnRemove;
    }
}