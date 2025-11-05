namespace LibraryManager.Forms
{
    partial class frmConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnect));
            groupBox1 = new GroupBox();
            btnConnectDBSQLServerAuthentication = new Button();
            btnConnectDBWindowsAuthentication = new Button();
            txtPassSQLServerAuth = new TextBox();
            label5 = new Label();
            txtUserSQLServerAuth = new TextBox();
            label4 = new Label();
            txtNameSVSQLServerAuth = new TextBox();
            label3 = new Label();
            cbSQLServerAuthentication = new CheckBox();
            label2 = new Label();
            cbWindowsAuthentication = new CheckBox();
            txtNameSVWindowsAuth = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnectDBSQLServerAuthentication);
            groupBox1.Controls.Add(btnConnectDBWindowsAuthentication);
            groupBox1.Controls.Add(txtPassSQLServerAuth);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUserSQLServerAuth);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNameSVSQLServerAuth);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbSQLServerAuthentication);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbWindowsAuthentication);
            groupBox1.Controls.Add(txtNameSVWindowsAuth);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 408);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại kết nối DB";
            // 
            // btnConnectDBSQLServerAuthentication
            // 
            btnConnectDBSQLServerAuthentication.Location = new Point(231, 357);
            btnConnectDBSQLServerAuthentication.Name = "btnConnectDBSQLServerAuthentication";
            btnConnectDBSQLServerAuthentication.Size = new Size(71, 45);
            btnConnectDBSQLServerAuthentication.TabIndex = 13;
            btnConnectDBSQLServerAuthentication.Text = "Kết nối";
            btnConnectDBSQLServerAuthentication.UseVisualStyleBackColor = true;
            btnConnectDBSQLServerAuthentication.Click += btnConnectDBSQLServerAuthentication_Click;
            // 
            // btnConnectDBWindowsAuthentication
            // 
            btnConnectDBWindowsAuthentication.Location = new Point(225, 69);
            btnConnectDBWindowsAuthentication.Name = "btnConnectDBWindowsAuthentication";
            btnConnectDBWindowsAuthentication.Size = new Size(71, 45);
            btnConnectDBWindowsAuthentication.TabIndex = 12;
            btnConnectDBWindowsAuthentication.Text = "Kết nối";
            btnConnectDBWindowsAuthentication.UseVisualStyleBackColor = true;
            btnConnectDBWindowsAuthentication.Click += btnConnectDBWindowsAuthentication_Click;
            // 
            // txtPassSQLServerAuth
            // 
            txtPassSQLServerAuth.BorderStyle = BorderStyle.FixedSingle;
            txtPassSQLServerAuth.Location = new Point(17, 316);
            txtPassSQLServerAuth.Name = "txtPassSQLServerAuth";
            txtPassSQLServerAuth.Size = new Size(186, 23);
            txtPassSQLServerAuth.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 298);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "Password";
            // 
            // txtUserSQLServerAuth
            // 
            txtUserSQLServerAuth.BorderStyle = BorderStyle.FixedSingle;
            txtUserSQLServerAuth.Location = new Point(17, 256);
            txtUserSQLServerAuth.Name = "txtUserSQLServerAuth";
            txtUserSQLServerAuth.Size = new Size(186, 23);
            txtUserSQLServerAuth.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 238);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "Username";
            // 
            // txtNameSVSQLServerAuth
            // 
            txtNameSVSQLServerAuth.BorderStyle = BorderStyle.FixedSingle;
            txtNameSVSQLServerAuth.Location = new Point(17, 198);
            txtNameSVSQLServerAuth.Name = "txtNameSVSQLServerAuth";
            txtNameSVSQLServerAuth.Size = new Size(186, 23);
            txtNameSVSQLServerAuth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 180);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Tên server";
            // 
            // cbSQLServerAuthentication
            // 
            cbSQLServerAuthentication.AutoSize = true;
            cbSQLServerAuthentication.Location = new Point(57, 142);
            cbSQLServerAuthentication.Name = "cbSQLServerAuthentication";
            cbSQLServerAuthentication.Size = new Size(164, 19);
            cbSQLServerAuthentication.TabIndex = 4;
            cbSQLServerAuthentication.Text = "SQL Server Authentication";
            cbSQLServerAuthentication.UseVisualStyleBackColor = true;
            cbSQLServerAuthentication.CheckedChanged += cbSQLServerAuthentication_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 117);
            label2.Name = "label2";
            label2.Size = new Size(287, 15);
            label2.TabIndex = 3;
            label2.Text = "===================================";
            // 
            // cbWindowsAuthentication
            // 
            cbWindowsAuthentication.AutoSize = true;
            cbWindowsAuthentication.Location = new Point(57, 22);
            cbWindowsAuthentication.Name = "cbWindowsAuthentication";
            cbWindowsAuthentication.Size = new Size(157, 19);
            cbWindowsAuthentication.TabIndex = 0;
            cbWindowsAuthentication.Text = "Windows Authentication";
            cbWindowsAuthentication.UseVisualStyleBackColor = true;
            cbWindowsAuthentication.CheckedChanged += cbWindowsAuthentication_CheckedChanged;
            // 
            // txtNameSVWindowsAuth
            // 
            txtNameSVWindowsAuth.BorderStyle = BorderStyle.FixedSingle;
            txtNameSVWindowsAuth.Location = new Point(11, 71);
            txtNameSVWindowsAuth.Name = "txtNameSVWindowsAuth";
            txtNameSVWindowsAuth.Size = new Size(192, 23);
            txtNameSVWindowsAuth.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên server";
            // 
            // frmConnect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 432);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmConnect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConnect";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConnectDBSQLServerAuthentication;
        private Button btnConnectDBWindowsAuthentication;
        private TextBox txtPassSQLServerAuth;
        private Label label5;
        private TextBox txtUserSQLServerAuth;
        private Label label4;
        private TextBox txtNameSVSQLServerAuth;
        private Label label3;
        private CheckBox cbSQLServerAuthentication;
        private Label label2;
        private CheckBox cbWindowsAuthentication;
        private TextBox txtNameSVWindowsAuth;
        private Label label1;
    }
}