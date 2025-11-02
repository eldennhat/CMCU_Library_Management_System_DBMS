namespace LibraryManager.Forms
{
    partial class frmRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            label3 = new Label();
            cbRoleRegister = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtPassRegister = new TextBox();
            txtUserRegister = new TextBox();
            btnRegister = new Button();
            label4 = new Label();
            txtPhoneRegister = new TextBox();
            label6 = new Label();
            btnLogin = new Button();
            label7 = new Label();
            cbRoleLogin = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            txtPassLogin = new TextBox();
            txtUserLogin = new TextBox();
            dataGridView1 = new DataGridView();
            registerUserBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registerUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 73);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 18;
            label3.Text = "Chức vụ";
            // 
            // cbRoleRegister
            // 
            cbRoleRegister.FormattingEnabled = true;
            cbRoleRegister.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbRoleRegister.Location = new Point(95, 70);
            cbRoleRegister.Name = "cbRoleRegister";
            cbRoleRegister.Size = new Size(100, 23);
            cbRoleRegister.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 16;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 15;
            label1.Text = "Tài khoản";
            // 
            // txtPassRegister
            // 
            txtPassRegister.BorderStyle = BorderStyle.FixedSingle;
            txtPassRegister.Location = new Point(95, 41);
            txtPassRegister.Name = "txtPassRegister";
            txtPassRegister.Size = new Size(75, 23);
            txtPassRegister.TabIndex = 14;
            // 
            // txtUserRegister
            // 
            txtUserRegister.BorderStyle = BorderStyle.FixedSingle;
            txtUserRegister.Location = new Point(95, 12);
            txtUserRegister.Name = "txtUserRegister";
            txtUserRegister.Size = new Size(129, 23);
            txtUserRegister.TabIndex = 13;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(95, 143);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(87, 32);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Đăng kí";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 101);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 21;
            label4.Text = "Số điện thoại";
            // 
            // txtPhoneRegister
            // 
            txtPhoneRegister.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneRegister.Location = new Point(95, 99);
            txtPhoneRegister.Name = "txtPhoneRegister";
            txtPhoneRegister.Size = new Size(144, 23);
            txtPhoneRegister.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(263, 12);
            label6.Name = "label6";
            label6.Size = new Size(13, 195);
            label6.TabIndex = 22;
            label6.Text = "||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n||\r\n";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(359, 111);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(87, 32);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 73);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 28;
            label7.Text = "Chức vụ";
            // 
            // cbRoleLogin
            // 
            cbRoleLogin.FormattingEnabled = true;
            cbRoleLogin.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbRoleLogin.Location = new Point(359, 70);
            cbRoleLogin.Name = "cbRoleLogin";
            cbRoleLogin.Size = new Size(121, 23);
            cbRoleLogin.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(295, 43);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 26;
            label8.Text = "Mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(295, 14);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 25;
            label9.Text = "Tài khoản";
            // 
            // txtPassLogin
            // 
            txtPassLogin.BorderStyle = BorderStyle.FixedSingle;
            txtPassLogin.Location = new Point(359, 41);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(100, 23);
            txtPassLogin.TabIndex = 24;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BorderStyle = BorderStyle.FixedSingle;
            txtUserLogin.Location = new Point(359, 12);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(164, 23);
            txtUserLogin.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dataGridView1.DataSource = registerUserBindingSource;
            dataGridView1.Location = new Point(1, 222);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(573, 226);
            dataGridView1.TabIndex = 30;
            // 
            // registerUserBindingSource
            // 
            registerUserBindingSource.DataSource = typeof(Models.Other.RegisterUser);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            roleDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.ReadOnly = true;
            roleDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "phoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            phoneNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(574, 448);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogin);
            Controls.Add(label7);
            Controls.Add(cbRoleLogin);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtPassLogin);
            Controls.Add(txtUserLogin);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtPhoneRegister);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(cbRoleRegister);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassRegister);
            Controls.Add(txtUserRegister);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRegister";
            Text = "Đăng kí - Đăng nhập";
            Load += frmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)registerUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private ComboBox cbRoleRegister;
        private Label label2;
        private Label label1;
        private TextBox txtPassRegister;
        private TextBox txtUserRegister;
        private Button btnRegister;
        private Label label4;
        private TextBox txtPhoneRegister;
        private Label label6;
        private Button btnLogin;
        private Label label7;
        private ComboBox cbRoleLogin;
        private Label label8;
        private Label label9;
        private TextBox txtPassLogin;
        private TextBox txtUserLogin;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource registerUserBindingSource;
    }
}
