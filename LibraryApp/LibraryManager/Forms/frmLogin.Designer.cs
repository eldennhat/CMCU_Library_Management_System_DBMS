namespace LibraryManager.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            label7 = new Label();
            cbRoleLogin = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            txtPassLogin = new TextBox();
            txtUserLogin = new TextBox();
            registerUserBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)registerUserBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(75, 111);
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
            label7.Location = new Point(12, 73);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 28;
            label7.Text = "Chức vụ";
            // 
            // cbRoleLogin
            // 
            cbRoleLogin.FormattingEnabled = true;
            cbRoleLogin.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbRoleLogin.Location = new Point(75, 70);
            cbRoleLogin.Name = "cbRoleLogin";
            cbRoleLogin.Size = new Size(121, 23);
            cbRoleLogin.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 43);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 26;
            label8.Text = "Mật khẩu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 14);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 25;
            label9.Text = "Tài khoản";
            // 
            // txtPassLogin
            // 
            txtPassLogin.BorderStyle = BorderStyle.FixedSingle;
            txtPassLogin.Location = new Point(75, 41);
            txtPassLogin.Name = "txtPassLogin";
            txtPassLogin.Size = new Size(100, 23);
            txtPassLogin.TabIndex = 24;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BorderStyle = BorderStyle.FixedSingle;
            txtUserLogin.Location = new Point(75, 12);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(164, 23);
            txtUserLogin.TabIndex = 23;
            // 
            // registerUserBindingSource
            // 
            registerUserBindingSource.DataSource = typeof(Models.Other.LoginrUser);
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(254, 170);
            Controls.Add(btnLogin);
            Controls.Add(label7);
            Controls.Add(cbRoleLogin);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(txtPassLogin);
            Controls.Add(txtUserLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmRegister";
            Text = "Đăng kí - Đăng nhập";
            Load += frmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)registerUserBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Label label7;
        private ComboBox cbRoleLogin;
        private Label label8;
        private Label label9;
        private TextBox txtPassLogin;
        private TextBox txtUserLogin;
        private BindingSource registerUserBindingSource;
    }
}
