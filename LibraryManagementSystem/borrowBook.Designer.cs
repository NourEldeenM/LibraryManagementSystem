namespace LibraryManagementSystem
{
    partial class borrowBook
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
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.book = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.IsbnNotCorrect = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.usernameNotValid = new System.Windows.Forms.Label();
            this.isbnNotFound = new System.Windows.Forms.Label();
            this.bookFinished = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(160, 104);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(150, 27);
            this.label.TabIndex = 10;
            this.label.Text = "Borrow Book";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 96);
            this.panel1.TabIndex = 9;
            // 
            // book
            // 
            this.book.AccessibleName = "";
            this.book.AutoSize = true;
            this.book.Location = new System.Drawing.Point(174, 285);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(120, 27);
            this.book.TabIndex = 16;
            this.book.Text = "Book ISBN";
            // 
            // isbnText
            // 
            this.isbnText.BackColor = System.Drawing.Color.White;
            this.isbnText.Location = new System.Drawing.Point(94, 317);
            this.isbnText.Margin = new System.Windows.Forms.Padding(5);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(269, 36);
            this.isbnText.TabIndex = 15;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // user
            // 
            this.user.AccessibleName = "";
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(168, 174);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(126, 27);
            this.user.TabIndex = 14;
            this.user.Text = "Username";
            this.user.Click += new System.EventHandler(this.Email_Click);
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(94, 206);
            this.usernameText.Margin = new System.Windows.Forms.Padding(5);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(269, 36);
            this.usernameText.TabIndex = 13;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // IsbnNotCorrect
            // 
            this.IsbnNotCorrect.AutoSize = true;
            this.IsbnNotCorrect.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsbnNotCorrect.ForeColor = System.Drawing.Color.Red;
            this.IsbnNotCorrect.Location = new System.Drawing.Point(133, 358);
            this.IsbnNotCorrect.Name = "IsbnNotCorrect";
            this.IsbnNotCorrect.Size = new System.Drawing.Size(192, 21);
            this.IsbnNotCorrect.TabIndex = 20;
            this.IsbnNotCorrect.Text = "ISBN has numbers only";
            this.IsbnNotCorrect.Click += new System.EventHandler(this.IsbnNotCorrect_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.borrowBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.borrowBtn.Location = new System.Drawing.Point(152, 409);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(159, 51);
            this.borrowBtn.TabIndex = 21;
            this.borrowBtn.Text = "borrow";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // usernameNotValid
            // 
            this.usernameNotValid.AutoSize = true;
            this.usernameNotValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameNotValid.ForeColor = System.Drawing.Color.Red;
            this.usernameNotValid.Location = new System.Drawing.Point(142, 247);
            this.usernameNotValid.Name = "usernameNotValid";
            this.usernameNotValid.Size = new System.Drawing.Size(179, 21);
            this.usernameNotValid.TabIndex = 22;
            this.usernameNotValid.Text = "Username not found";
            // 
            // isbnNotFound
            // 
            this.isbnNotFound.AutoSize = true;
            this.isbnNotFound.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnNotFound.ForeColor = System.Drawing.Color.Red;
            this.isbnNotFound.Location = new System.Drawing.Point(103, 385);
            this.isbnNotFound.Name = "isbnNotFound";
            this.isbnNotFound.Size = new System.Drawing.Size(270, 21);
            this.isbnNotFound.TabIndex = 23;
            this.isbnNotFound.Text = "ISBN not valid or book is missing";
            this.isbnNotFound.Click += new System.EventHandler(this.isbnNotFound_Click);
            // 
            // bookFinished
            // 
            this.bookFinished.AutoSize = true;
            this.bookFinished.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookFinished.ForeColor = System.Drawing.Color.Red;
            this.bookFinished.Location = new System.Drawing.Point(141, 385);
            this.bookFinished.Name = "bookFinished";
            this.bookFinished.Size = new System.Drawing.Size(180, 21);
            this.bookFinished.TabIndex = 24;
            this.bookFinished.Text = "Book is out of copies";
            this.bookFinished.Click += new System.EventHandler(this.bookFinished_Click);
            // 
            // borrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(462, 548);
            this.Controls.Add(this.bookFinished);
            this.Controls.Add(this.isbnNotFound);
            this.Controls.Add(this.usernameNotValid);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.IsbnNotCorrect);
            this.Controls.Add(this.book);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "borrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borrowBook";
            this.Load += new System.EventHandler(this.borrowBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label book;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label IsbnNotCorrect;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Label usernameNotValid;
        private System.Windows.Forms.Label isbnNotFound;
        private System.Windows.Forms.Label bookFinished;
    }
}