namespace LibraryManager.Forms.BasicDirectory
{
    partial class frmAuthorManagment
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            penNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAuthorName = new TextBox();
            txtAuthorPenName = new TextBox();
            txtAuthorPhoneNumber = new TextBox();
            btnAddAuthor = new Button();
            btnEditAuthor = new Button();
            btnDeleteAuthor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, penNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dataGridView1.DataSource = authorBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(503, 409);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Tên tác giả";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // penNameDataGridViewTextBoxColumn
            // 
            penNameDataGridViewTextBoxColumn.DataPropertyName = "PenName";
            penNameDataGridViewTextBoxColumn.HeaderText = "Bút danh";
            penNameDataGridViewTextBoxColumn.Name = "penNameDataGridViewTextBoxColumn";
            penNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataSource = typeof(Models.Sub.Author);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(559, 29);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Tên tác giả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(559, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Bút danh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 108);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Số điện thoại";
            // 
            // txtAuthorName
            // 
            txtAuthorName.BorderStyle = BorderStyle.FixedSingle;
            txtAuthorName.Location = new Point(629, 26);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(166, 23);
            txtAuthorName.TabIndex = 5;
            // 
            // txtAuthorPenName
            // 
            txtAuthorPenName.BorderStyle = BorderStyle.FixedSingle;
            txtAuthorPenName.Location = new Point(629, 65);
            txtAuthorPenName.Name = "txtAuthorPenName";
            txtAuthorPenName.Size = new Size(166, 23);
            txtAuthorPenName.TabIndex = 6;
            // 
            // txtAuthorPhoneNumber
            // 
            txtAuthorPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtAuthorPhoneNumber.Location = new Point(629, 104);
            txtAuthorPhoneNumber.Name = "txtAuthorPhoneNumber";
            txtAuthorPhoneNumber.Size = new Size(166, 23);
            txtAuthorPhoneNumber.TabIndex = 7;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.Location = new Point(526, 154);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(87, 29);
            btnAddAuthor.TabIndex = 8;
            btnAddAuthor.Text = "Thêm";
            btnAddAuthor.UseVisualStyleBackColor = true;
            btnAddAuthor.Click += btnAddAuthor_Click;
            // 
            // btnEditAuthor
            // 
            btnEditAuthor.Location = new Point(629, 154);
            btnEditAuthor.Name = "btnEditAuthor";
            btnEditAuthor.Size = new Size(87, 29);
            btnEditAuthor.TabIndex = 9;
            btnEditAuthor.Text = "Sửa";
            btnEditAuthor.UseVisualStyleBackColor = true;
            btnEditAuthor.Click += btnEditAuthor_Click;
            // 
            // btnDeleteAuthor
            // 
            btnDeleteAuthor.Location = new Point(732, 154);
            btnDeleteAuthor.Name = "btnDeleteAuthor";
            btnDeleteAuthor.Size = new Size(87, 29);
            btnDeleteAuthor.TabIndex = 10;
            btnDeleteAuthor.Text = "Xoá";
            btnDeleteAuthor.UseVisualStyleBackColor = true;
            btnDeleteAuthor.Click += btnDeleteAuthor_Click;
            // 
            // frmAuthorManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(846, 409);
            Controls.Add(btnDeleteAuthor);
            Controls.Add(btnEditAuthor);
            Controls.Add(btnAddAuthor);
            Controls.Add(txtAuthorPhoneNumber);
            Controls.Add(txtAuthorPenName);
            Controls.Add(txtAuthorName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "frmAuthorManagment";
            Text = "frmAuthorManagement";
            Load += frmAuthorManagment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAuthorName;
        private TextBox txtAuthorPenName;
        private TextBox txtAuthorPhoneNumber;
        private Button btnAddAuthor;
        private Button btnEditAuthor;
        private Button btnDeleteAuthor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn penNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private BindingSource authorBindingSource;
    }
}