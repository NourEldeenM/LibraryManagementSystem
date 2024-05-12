namespace LibraryManagementSystem
{
    partial class signupForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.reenterPassword = new System.Windows.Forms.Label();
            this.reEnterPasswordText = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.passwordNotCorrect = new System.Windows.Forms.Label();
            this.checkBoxPass2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 96);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Signup";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.AccessibleName = "";
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(236, 157);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(74, 27);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Username_Click);
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(131, 189);
            this.emailText.Margin = new System.Windows.Forms.Padding(5);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(269, 36);
            this.emailText.TabIndex = 9;
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(211, 228);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(126, 27);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(131, 260);
            this.usernameText.Margin = new System.Windows.Forms.Padding(5);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(269, 36);
            this.usernameText.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.AccessibleName = "";
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(211, 302);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(118, 27);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(131, 334);
            this.passwordText.Margin = new System.Windows.Forms.Padding(5);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(269, 36);
            this.passwordText.TabIndex = 13;
            // 
            // reenterPassword
            // 
            this.reenterPassword.AccessibleName = "";
            this.reenterPassword.AutoSize = true;
            this.reenterPassword.Location = new System.Drawing.Point(157, 377);
            this.reenterPassword.Name = "reenterPassword";
            this.reenterPassword.Size = new System.Drawing.Size(222, 27);
            this.reenterPassword.TabIndex = 16;
            this.reenterPassword.Text = "Re-enter password";
            // 
            // reEnterPasswordText
            // 
            this.reEnterPasswordText.BackColor = System.Drawing.Color.White;
            this.reEnterPasswordText.Location = new System.Drawing.Point(131, 409);
            this.reEnterPasswordText.Margin = new System.Windows.Forms.Padding(5);
            this.reEnterPasswordText.Name = "reEnterPasswordText";
            this.reEnterPasswordText.Size = new System.Drawing.Size(269, 36);
            this.reEnterPasswordText.TabIndex = 15;
            this.reEnterPasswordText.TextChanged += new System.EventHandler(this.reEnterPasswordText_TextChanged);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup.Location = new System.Drawing.Point(178, 540);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(159, 51);
            this.signup.TabIndex = 17;
            this.signup.Text = "signup";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.submit_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdmin.Location = new System.Drawing.Point(53, 492);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(190, 27);
            this.checkBoxAdmin.TabIndex = 18;
            this.checkBoxAdmin.Text = "signup as admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // passwordNotCorrect
            // 
            this.passwordNotCorrect.AutoSize = true;
            this.passwordNotCorrect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordNotCorrect.ForeColor = System.Drawing.Color.Red;
            this.passwordNotCorrect.Location = new System.Drawing.Point(173, 450);
            this.passwordNotCorrect.Name = "passwordNotCorrect";
            this.passwordNotCorrect.Size = new System.Drawing.Size(206, 21);
            this.passwordNotCorrect.TabIndex = 19;
            this.passwordNotCorrect.Text = "not the same password";
            this.passwordNotCorrect.Click += new System.EventHandler(this.passwordNotCorrect_Click);
            // 
            // checkBoxPass2
            // 
            this.checkBoxPass2.AutoSize = true;
            this.checkBoxPass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPass2.Location = new System.Drawing.Point(296, 492);
            this.checkBoxPass2.Name = "checkBoxPass2";
            this.checkBoxPass2.Size = new System.Drawing.Size(184, 27);
            this.checkBoxPass2.TabIndex = 20;
            this.checkBoxPass2.Text = "show password";
            this.checkBoxPass2.UseVisualStyleBackColor = true;
            this.checkBoxPass2.CheckedChanged += new System.EventHandler(this.checkBoxPass2_CheckedChanged);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(537, 622);
            this.Controls.Add(this.checkBoxPass2);
            this.Controls.Add(this.passwordNotCorrect);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.reenterPassword);
            this.Controls.Add(this.reEnterPasswordText);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "signupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label reenterPassword;
        private System.Windows.Forms.TextBox reEnterPasswordText;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Label passwordNotCorrect;
        private System.Windows.Forms.CheckBox checkBoxPass2;
    }
}