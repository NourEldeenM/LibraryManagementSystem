namespace LibraryManagementSystem
{
    partial class menuAdmin
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.editBookBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.updateDetailsBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(274, 85);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(143, 27);
            this.mainLabel.TabIndex = 11;
            this.mainLabel.Text = "Main Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 72);
            this.panel1.TabIndex = 10;
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBookBtn.Location = new System.Drawing.Point(108, 168);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(219, 51);
            this.addBookBtn.TabIndex = 12;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            // 
            // editBookBtn
            // 
            this.editBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.editBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editBookBtn.Location = new System.Drawing.Point(354, 168);
            this.editBookBtn.Name = "editBookBtn";
            this.editBookBtn.Size = new System.Drawing.Size(219, 51);
            this.editBookBtn.TabIndex = 13;
            this.editBookBtn.Text = "Edit Book";
            this.editBookBtn.UseVisualStyleBackColor = false;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.removeUserBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeUserBtn.Location = new System.Drawing.Point(354, 258);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(219, 51);
            this.removeUserBtn.TabIndex = 14;
            this.removeUserBtn.Text = "Remove User";
            this.removeUserBtn.UseVisualStyleBackColor = false;
            // 
            // updateDetailsBtn
            // 
            this.updateDetailsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.updateDetailsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateDetailsBtn.Location = new System.Drawing.Point(108, 258);
            this.updateDetailsBtn.Name = "updateDetailsBtn";
            this.updateDetailsBtn.Size = new System.Drawing.Size(219, 51);
            this.updateDetailsBtn.TabIndex = 15;
            this.updateDetailsBtn.Text = "Update Details";
            this.updateDetailsBtn.UseVisualStyleBackColor = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(232, 340);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(219, 51);
            this.logoutBtn.TabIndex = 16;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(684, 490);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updateDetailsBtn);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.editBookBtn);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "menuAdmin";
            this.Text = "menuAdmin";
            this.Load += new System.EventHandler(this.menuAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button editBookBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Button updateDetailsBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}