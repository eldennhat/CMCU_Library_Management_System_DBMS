namespace Managment.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            label1 = new Label();
            txtAcc = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(83, 120);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 38);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // txtAcc
            // 
            txtAcc.BorderStyle = BorderStyle.FixedSingle;
            txtAcc.Location = new Point(83, 12);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(129, 23);
            txtAcc.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(83, 46);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(105, 23);
            txtPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 50);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 84);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Chức vụ";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Librarian" });
            cbRole.Location = new Point(82, 80);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(71, 23);
            cbRole.TabIndex = 7;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(254, 170);
            Controls.Add(cbRole);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(label3);
            Controls.Add(txtAcc);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private Button btnLogin;
        private Label label1;
        private TextBox txtAcc;
        private TextBox txtPass;
        private Label label3;
        private Label label2;
        private ComboBox cbRole;
    }
}