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
            this.login_in_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 87);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Signup";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Email
            // 
            this.Email.AccessibleName = "";
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(234, 134);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 22);
            this.Email.TabIndex = 10;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.Username_Click);
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.Color.White;
            this.emailText.Location = new System.Drawing.Point(131, 161);
            this.emailText.Margin = new System.Windows.Forms.Padding(5);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(269, 30);
            this.emailText.TabIndex = 9;
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(205, 196);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(101, 22);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click_1);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(131, 235);
            this.usernameText.Margin = new System.Windows.Forms.Padding(5);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(269, 30);
            this.usernameText.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.AccessibleName = "";
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(211, 270);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(95, 22);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.Color.White;
            this.passwordText.Location = new System.Drawing.Point(131, 311);
            this.passwordText.Margin = new System.Windows.Forms.Padding(5);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(269, 30);
            this.passwordText.TabIndex = 13;
            // 
            // reenterPassword
            // 
            this.reenterPassword.AccessibleName = "";
            this.reenterPassword.AutoSize = true;
            this.reenterPassword.Location = new System.Drawing.Point(173, 346);
            this.reenterPassword.Name = "reenterPassword";
            this.reenterPassword.Size = new System.Drawing.Size(181, 22);
            this.reenterPassword.TabIndex = 16;
            this.reenterPassword.Text = "Re-enter password";
            // 
            // reEnterPasswordText
            // 
            this.reEnterPasswordText.BackColor = System.Drawing.Color.White;
            this.reEnterPasswordText.Location = new System.Drawing.Point(131, 382);
            this.reEnterPasswordText.Margin = new System.Windows.Forms.Padding(5);
            this.reEnterPasswordText.Name = "reEnterPasswordText";
            this.reEnterPasswordText.Size = new System.Drawing.Size(269, 30);
            this.reEnterPasswordText.TabIndex = 15;
            this.reEnterPasswordText.TextChanged += new System.EventHandler(this.reEnterPasswordText_TextChanged);
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signup.Location = new System.Drawing.Point(172, 497);
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
            this.checkBoxAdmin.Location = new System.Drawing.Point(51, 466);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(155, 25);
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
            this.passwordNotCorrect.Location = new System.Drawing.Point(168, 417);
            this.passwordNotCorrect.Name = "passwordNotCorrect";
            this.passwordNotCorrect.Size = new System.Drawing.Size(169, 19);
            this.passwordNotCorrect.TabIndex = 19;
            this.passwordNotCorrect.Text = "not the same password";
            this.passwordNotCorrect.Click += new System.EventHandler(this.passwordNotCorrect_Click);
            // 
            // checkBoxPass2
            // 
            this.checkBoxPass2.AutoSize = true;
            this.checkBoxPass2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPass2.Location = new System.Drawing.Point(294, 466);
            this.checkBoxPass2.Name = "checkBoxPass2";
            this.checkBoxPass2.Size = new System.Drawing.Size(147, 25);
            this.checkBoxPass2.TabIndex = 20;
            this.checkBoxPass2.Text = "show password";
            this.checkBoxPass2.UseVisualStyleBackColor = true;
            this.checkBoxPass2.CheckedChanged += new System.EventHandler(this.checkBoxPass2_CheckedChanged);
            // 
            // login_in_signup
            // 
            this.login_in_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.login_in_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_in_signup.Location = new System.Drawing.Point(341, 559);
            this.login_in_signup.Name = "login_in_signup";
            this.login_in_signup.Size = new System.Drawing.Size(159, 51);
            this.login_in_signup.TabIndex = 21;
            this.login_in_signup.Text = "LogIn";
            this.login_in_signup.UseVisualStyleBackColor = false;
            this.login_in_signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Already have account ?";
            // 
            // alert
            // 
            this.alert.AutoSize = true;
            this.alert.Font = new System.Drawing.Font("Century Gothic", 11.2F);
            this.alert.ForeColor = System.Drawing.Color.Red;
            this.alert.Location = new System.Drawing.Point(176, 436);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(166, 20);
            this.alert.TabIndex = 23;
            this.alert.Text = "All fields are required ";
            this.alert.Click += new System.EventHandler(this.alert_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(537, 622);
            this.Controls.Add(this.alert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_in_signup);
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
        private System.Windows.Forms.Button login_in_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alert;
    }
}