namespace LibraryManagmentSystem
{
    partial class UpdateUserForm
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
            this.Label0 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.NuserN = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.userNVal = new System.Windows.Forms.TextBox();
            this.NusernameVal = new System.Windows.Forms.TextBox();
            this.passVal = new System.Windows.Forms.TextBox();
            this.EmailVal = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Label0
            //
            this.Label0.AutoSize =  true;
            this.Label0.Text =  "Update details";
            this.Label0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label0.Location = new System.Drawing.Point(204,28);
            this.Label0.Size = new System.Drawing.Size(106,20);
            //
            // username
            //
            this.username.AutoSize =  true;
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Text =  "Current user name";
            this.username.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(20,88);
            this.username.Size = new System.Drawing.Size(124,19);
            this.username.TabIndex = 1;
            //
            // NuserN
            //
            this.NuserN.AutoSize =  true;
            this.NuserN.Text =  "New user name";
            this.NuserN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NuserN.Location = new System.Drawing.Point(24,156);
            this.NuserN.Size = new System.Drawing.Size(104,19);
            this.NuserN.TabIndex = 2;
            //
            // Password
            //
            this.Password.AutoSize =  true;
            this.Password.Text =  "Password";
            this.Password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Password.Location = new System.Drawing.Point(24,228);
            this.Password.Size = new System.Drawing.Size(67,19);
            this.Password.TabIndex = 3;
            //
            // Email
            //
            this.Email.AutoSize =  true;
            this.Email.Text =  "Email";
            this.Email.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(36,300);
            this.Email.Size = new System.Drawing.Size(41,19);
            this.Email.TabIndex = 4;
            //
            // userNVal
            //
            this.userNVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNVal.Location = new System.Drawing.Point(156,88);
            this.userNVal.Size = new System.Drawing.Size(156,25);
            this.userNVal.TabIndex = 5;
            //
            // NusernameVal
            //
            this.NusernameVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NusernameVal.Location = new System.Drawing.Point(156,148);
            this.NusernameVal.Size = new System.Drawing.Size(156,25);
            this.NusernameVal.TabIndex = 6;
            //
            // passVal
            //
            
            this.passVal.Modified =  true;
            this.passVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passVal.Location = new System.Drawing.Point(156,224);
            this.passVal.Size = new System.Drawing.Size(160,25);
            this.passVal.TabIndex = 7;
            //
            // EmailVal
            //
            
            this.EmailVal.Modified =  true;
            this.EmailVal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailVal.Location = new System.Drawing.Point(156,296);
            this.EmailVal.Size = new System.Drawing.Size(160,25);
            this.EmailVal.TabIndex = 8;
            //
            // UpdateBtn
            //
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(75, 114, 175);
            this.UpdateBtn.Text =  "Update";
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(312,384);
            this.UpdateBtn.Size = new System.Drawing.Size(116,36);
            this.UpdateBtn.TabIndex = 9;
             this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            //
            // Clear
            //
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Text =  "Clear";
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(48,384);
            this.Clear.Size = new System.Drawing.Size(100,36);
            this.Clear.TabIndex = 10;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
         //
         // form
         //
            this.AutoScaleBaseSize = new System.Drawing.Size(6,18);
            this.Size = new System.Drawing.Size(536,488);
            this.Text =  "Form1";
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Controls.Add(this.Label0);
            this.Controls.Add(this.username);
            this.Controls.Add(this.NuserN);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.userNVal);
            this.Controls.Add(this.NusernameVal);
            this.Controls.Add(this.passVal);
            this.Controls.Add(this.EmailVal);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Clear);
            this.ResumeLayout(false);
        } 

        #endregion 

        private System.Windows.Forms.Label Label0;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label NuserN;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox userNVal;
        private System.Windows.Forms.TextBox NusernameVal;
        private System.Windows.Forms.TextBox passVal;
        private System.Windows.Forms.TextBox EmailVal;

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Clear;
    }
}

