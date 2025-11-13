namespace Managment.Forms
{
    partial class frmConnectDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnectDB));
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtPasswordSQLAuthen = new TextBox();
            label3 = new Label();
            txtUsernameSQLAuthen = new TextBox();
            btnConnectSQLAuthen = new Button();
            label2 = new Label();
            txtServerSQLAuthen = new TextBox();
            cbConnectSQLAuthen = new CheckBox();
            label1 = new Label();
            btnConnectWindowsAuthen = new Button();
            lbConnectWindowsAuthen = new Label();
            txtConnectWindowsAuthent = new TextBox();
            cbConnectWindowsAuthen = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPasswordSQLAuthen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtUsernameSQLAuthen);
            groupBox1.Controls.Add(btnConnectSQLAuthen);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtServerSQLAuthen);
            groupBox1.Controls.Add(cbConnectSQLAuthen);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnConnectWindowsAuthen);
            groupBox1.Controls.Add(lbConnectWindowsAuthen);
            groupBox1.Controls.Add(txtConnectWindowsAuthent);
            groupBox1.Controls.Add(cbConnectWindowsAuthen);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 408);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loại kết nối";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 318);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Password";
            // 
            // txtPasswordSQLAuthen
            // 
            txtPasswordSQLAuthen.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordSQLAuthen.Location = new Point(6, 339);
            txtPasswordSQLAuthen.Name = "txtPasswordSQLAuthen";
            txtPasswordSQLAuthen.Size = new Size(133, 23);
            txtPasswordSQLAuthen.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 253);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 10;
            label3.Text = "Username";
            // 
            // txtUsernameSQLAuthen
            // 
            txtUsernameSQLAuthen.BorderStyle = BorderStyle.FixedSingle;
            txtUsernameSQLAuthen.Location = new Point(6, 274);
            txtUsernameSQLAuthen.Name = "txtUsernameSQLAuthen";
            txtUsernameSQLAuthen.Size = new Size(133, 23);
            txtUsernameSQLAuthen.TabIndex = 9;
            // 
            // btnConnectSQLAuthen
            // 
            btnConnectSQLAuthen.Location = new Point(177, 358);
            btnConnectSQLAuthen.Name = "btnConnectSQLAuthen";
            btnConnectSQLAuthen.Size = new Size(75, 44);
            btnConnectSQLAuthen.TabIndex = 8;
            btnConnectSQLAuthen.Text = "Kết nối";
            btnConnectSQLAuthen.UseVisualStyleBackColor = true;
            btnConnectSQLAuthen.Click += btnConnectSQLAuthen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 194);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Tên server";
            // 
            // txtServerSQLAuthen
            // 
            txtServerSQLAuthen.BorderStyle = BorderStyle.FixedSingle;
            txtServerSQLAuthen.Location = new Point(6, 215);
            txtServerSQLAuthen.Name = "txtServerSQLAuthen";
            txtServerSQLAuthen.Size = new Size(133, 23);
            txtServerSQLAuthen.TabIndex = 6;
            // 
            // cbConnectSQLAuthen
            // 
            cbConnectSQLAuthen.AutoSize = true;
            cbConnectSQLAuthen.Location = new Point(6, 169);
            cbConnectSQLAuthen.Name = "cbConnectSQLAuthen";
            cbConnectSQLAuthen.Size = new Size(126, 19);
            cbConnectSQLAuthen.TabIndex = 5;
            cbConnectSQLAuthen.Text = "SQL Authenticaton";
            cbConnectSQLAuthen.UseVisualStyleBackColor = true;
            cbConnectSQLAuthen.CheckedChanged += cbConnectSQLAuthen_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 125);
            label1.Name = "label1";
            label1.Size = new Size(231, 15);
            label1.TabIndex = 4;
            label1.Text = "============================";
            // 
            // btnConnectWindowsAuthen
            // 
            btnConnectWindowsAuthen.Location = new Point(177, 49);
            btnConnectWindowsAuthen.Name = "btnConnectWindowsAuthen";
            btnConnectWindowsAuthen.Size = new Size(75, 44);
            btnConnectWindowsAuthen.TabIndex = 3;
            btnConnectWindowsAuthen.Text = "Kết nối";
            btnConnectWindowsAuthen.UseVisualStyleBackColor = true;
            btnConnectWindowsAuthen.Click += btnConnectWindowsAuthen_Click;
            // 
            // lbConnectWindowsAuthen
            // 
            lbConnectWindowsAuthen.AutoSize = true;
            lbConnectWindowsAuthen.Location = new Point(6, 49);
            lbConnectWindowsAuthen.Name = "lbConnectWindowsAuthen";
            lbConnectWindowsAuthen.Size = new Size(60, 15);
            lbConnectWindowsAuthen.TabIndex = 2;
            lbConnectWindowsAuthen.Text = "Tên server";
            // 
            // txtConnectWindowsAuthent
            // 
            txtConnectWindowsAuthent.BorderStyle = BorderStyle.FixedSingle;
            txtConnectWindowsAuthent.Location = new Point(6, 70);
            txtConnectWindowsAuthent.Name = "txtConnectWindowsAuthent";
            txtConnectWindowsAuthent.Size = new Size(133, 23);
            txtConnectWindowsAuthent.TabIndex = 1;
            // 
            // cbConnectWindowsAuthen
            // 
            cbConnectWindowsAuthen.AutoSize = true;
            cbConnectWindowsAuthen.Location = new Point(6, 22);
            cbConnectWindowsAuthen.Name = "cbConnectWindowsAuthen";
            cbConnectWindowsAuthen.Size = new Size(154, 19);
            cbConnectWindowsAuthen.TabIndex = 0;
            cbConnectWindowsAuthen.Text = "Windows Authenticaton";
            cbConnectWindowsAuthen.UseVisualStyleBackColor = true;
            cbConnectWindowsAuthen.CheckedChanged += cbConnectWindowsAuthen_CheckedChanged;
            // 
            // frmConnectDB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(282, 432);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmConnectDB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết nối database";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConnectWindowsAuthen;
        private Label lbConnectWindowsAuthen;
        private TextBox txtConnectWindowsAuthent;
        private CheckBox cbConnectWindowsAuthen;
        private Label label4;
        private TextBox txtPasswordSQLAuthen;
        private Label label3;
        private TextBox txtUsernameSQLAuthen;
        private Button btnConnectSQLAuthen;
        private Label label2;
        private TextBox txtServerSQLAuthen;
        private CheckBox cbConnectSQLAuthen;
        private Label label1;
    }
}
