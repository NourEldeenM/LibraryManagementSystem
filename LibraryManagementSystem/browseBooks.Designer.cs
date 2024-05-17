namespace LibraryManagementSystem
{
    partial class browseBooks
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.author = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.minISBN = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 67);
            this.panel1.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Location = new System.Drawing.Point(356, 77);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(88, 27);
            this.mainLabel.TabIndex = 10;
            this.mainLabel.Text = "search";
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 130);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(143, 27);
            this.Username.TabIndex = 9;
            this.Username.Text = "book name";
            // 
            // bookname
            // 
            this.bookname.BackColor = System.Drawing.Color.White;
            this.bookname.Location = new System.Drawing.Point(163, 127);
            this.bookname.Margin = new System.Windows.Forms.Padding(5);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(198, 36);
            this.bookname.TabIndex = 8;
            this.bookname.TextChanged += new System.EventHandler(this.bookname_TextChanged);
            // 
            // filterButton
            // 
            this.filterButton.AutoSize = true;
            this.filterButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(388, 135);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(69, 25);
            this.filterButton.TabIndex = 11;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.CheckedChanged += new System.EventHandler(this.filterButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 308);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.year);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maxISBN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.minISBN);
            this.groupBox1.Location = new System.Drawing.Point(484, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 249);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // author
            // 
            this.author.BackColor = System.Drawing.Color.White;
            this.author.Location = new System.Drawing.Point(112, 194);
            this.author.Margin = new System.Windows.Forms.Padding(5);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(185, 36);
            this.author.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Author";
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.White;
            this.year.Location = new System.Drawing.Point(112, 138);
            this.year.Margin = new System.Windows.Forms.Padding(5);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(185, 36);
            this.year.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "max";
            // 
            // maxISBN
            // 
            this.maxISBN.BackColor = System.Drawing.Color.White;
            this.maxISBN.Location = new System.Drawing.Point(202, 42);
            this.maxISBN.Margin = new System.Windows.Forms.Padding(5);
            this.maxISBN.Name = "maxISBN";
            this.maxISBN.Size = new System.Drawing.Size(95, 36);
            this.maxISBN.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "ISBN";
            // 
            // minISBN
            // 
            this.minISBN.BackColor = System.Drawing.Color.White;
            this.minISBN.Location = new System.Drawing.Point(97, 42);
            this.minISBN.Margin = new System.Windows.Forms.Padding(5);
            this.minISBN.Name = "minISBN";
            this.minISBN.Size = new System.Drawing.Size(95, 36);
            this.minISBN.TabIndex = 21;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(571, 361);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(159, 51);
            this.searchButton.TabIndex = 30;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // browseBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(811, 514);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "browseBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "browseBooks";
            this.Load += new System.EventHandler(this.browseBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.CheckBox filterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maxISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minISBN;
        private System.Windows.Forms.Button searchButton;
    }
}