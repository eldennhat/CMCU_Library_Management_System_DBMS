namespace LibraryManager.Forms.Other
{
    partial class frmBasicDirectory
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
            btnAuthorManagment = new Button();
            btnCategoryManagment = new Button();
            btnPublisherManagment = new Button();
            SuspendLayout();
            // 
            // btnAuthorManagment
            // 
            btnAuthorManagment.Location = new Point(12, 12);
            btnAuthorManagment.Name = "btnAuthorManagment";
            btnAuthorManagment.Size = new Size(351, 67);
            btnAuthorManagment.TabIndex = 0;
            btnAuthorManagment.Text = "Quản lý tác giả";
            btnAuthorManagment.UseVisualStyleBackColor = true;
            // 
            // btnCategoryManagment
            // 
            btnCategoryManagment.Location = new Point(12, 85);
            btnCategoryManagment.Name = "btnCategoryManagment";
            btnCategoryManagment.Size = new Size(351, 67);
            btnCategoryManagment.TabIndex = 1;
            btnCategoryManagment.Text = "Quản lý thể loại";
            btnCategoryManagment.UseVisualStyleBackColor = true;
            // 
            // btnPublisherManagment
            // 
            btnPublisherManagment.Location = new Point(12, 158);
            btnPublisherManagment.Name = "btnPublisherManagment";
            btnPublisherManagment.Size = new Size(351, 67);
            btnPublisherManagment.TabIndex = 2;
            btnPublisherManagment.Text = "Quản lý nhà xuất bản";
            btnPublisherManagment.UseVisualStyleBackColor = true;
            // 
            // formBasicDirectory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(375, 240);
            Controls.Add(btnPublisherManagment);
            Controls.Add(btnCategoryManagment);
            Controls.Add(btnAuthorManagment);
            MaximizeBox = false;
            Name = "formBasicDirectory";
            Text = "formBasicDirectory";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuthorManagment;
        private Button btnCategoryManagment;
        private Button btnPublisherManagment;
    }
}