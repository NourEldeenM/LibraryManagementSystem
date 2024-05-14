namespace LibraryManagementSystem
{
    partial class loginForm
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
            panel1 = new Panel();
            usernameText = new TextBox();
            textBox2 = new TextBox();
            Username = new Label();
            passwordText = new Label();
            passField = new TextBox();
            loginButton = new Button();
            label2 = new Label();
            checkBoxPass = new CheckBox();
            label1 = new Label();
            signup_in_login = new Button();
            fillAll = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 45, 78);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 93);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // usernameText
            // 
            usernameText.BackColor = Color.White;
            usernameText.Location = new Point(95, 199);
            usernameText.Margin = new Padding(5);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(269, 30);
            usernameText.TabIndex = 1;
            usernameText.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(471, 336);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 30);
            textBox2.TabIndex = 2;
            // 
            // Username
            // 
            Username.AccessibleName = "";
            Username.AutoSize = true;
            Username.Location = new Point(170, 156);
            Username.Name = "Username";
            Username.Size = new Size(101, 22);
            Username.TabIndex = 3;
            Username.Text = "Username";
            Username.Click += label1_Click;
            // 
            // passwordText
            // 
            passwordText.AccessibleName = "";
            passwordText.AutoSize = true;
            passwordText.Location = new Point(176, 246);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(95, 22);
            passwordText.TabIndex = 5;
            passwordText.Text = "Password";
            // 
            // passField
            // 
            passField.BackColor = Color.White;
            passField.Location = new Point(95, 291);
            passField.Margin = new Padding(5);
            passField.Name = "passField";
            passField.Size = new Size(269, 30);
            passField.TabIndex = 4;
            passField.TextChanged += passField_TextChanged;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(63, 114, 175);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(170, 347);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(123, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 22);
            label2.TabIndex = 7;
            label2.Text = "Login";
            // 
            // checkBoxPass
            // 
            checkBoxPass.AutoSize = true;
            checkBoxPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxPass.Location = new Point(161, 409);
            checkBoxPass.Name = "checkBoxPass";
            checkBoxPass.Size = new Size(147, 25);
            checkBoxPass.TabIndex = 9;
            checkBoxPass.Text = "show password";
            checkBoxPass.UseVisualStyleBackColor = true;
            checkBoxPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 481);
            label1.Name = "label1";
            label1.Size = new Size(220, 22);
            label1.TabIndex = 10;
            label1.Text = "Don't have account ? ";
            // 
            // signup_in_login
            // 
            signup_in_login.BackColor = Color.FromArgb(63, 114, 175);
            signup_in_login.ForeColor = SystemColors.ButtonHighlight;
            signup_in_login.Location = new Point(300, 471);
            signup_in_login.Name = "signup_in_login";
            signup_in_login.Size = new Size(123, 40);
            signup_in_login.TabIndex = 11;
            signup_in_login.Text = "SignUp";
            signup_in_login.UseVisualStyleBackColor = false;
            signup_in_login.Click += signup_in_login_Click;
            // 
            // fillAll
            // 
            fillAll.AccessibleName = "";
            fillAll.AutoSize = true;
            fillAll.ForeColor = Color.Red;
            fillAll.Location = new Point(131, 437);
            fillAll.Name = "fillAll";
            fillAll.Size = new Size(203, 22);
            fillAll.TabIndex = 12;
            fillAll.Text = "All fields are required!";
            fillAll.TextAlign = ContentAlignment.MiddleLeft;
            fillAll.Click += invalidData_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(469, 530);
            Controls.Add(fillAll);
            Controls.Add(signup_in_login);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(checkBoxPass);
            Controls.Add(loginButton);
            Controls.Add(passwordText);
            Controls.Add(passField);
            Controls.Add(Username);
            Controls.Add(textBox2);
            Controls.Add(usernameText);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup_in_login;
        private Label fillAll;
    }
}

