namespace LibraryManagementSystem
{
    partial class addBookAdmin
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
            this.ISBN = new System.Windows.Forms.Label();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.Publisher = new System.Windows.Forms.Label();
            this.publish = new System.Windows.Forms.TextBox();
            this.publishDate = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.isbnNotValid = new System.Windows.Forms.Label();
            this.publisherNotValid = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.isbnValid = new System.Windows.Forms.Label();
            this.publisherValid = new System.Windows.Forms.Label();
            this.priceSelect = new System.Windows.Forms.NumericUpDown();
            this.maxPrice = new System.Windows.Forms.Label();
            this.addBookValid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 72);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add Book";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ISBN
            // 
            this.ISBN.AccessibleName = "";
            this.ISBN.AutoSize = true;
            this.ISBN.Location = new System.Drawing.Point(53, 234);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(59, 27);
            this.ISBN.TabIndex = 12;
            this.ISBN.Text = "ISBN";
            // 
            // isbnText
            // 
            this.isbnText.BackColor = System.Drawing.Color.White;
            this.isbnText.Location = new System.Drawing.Point(249, 231);
            this.isbnText.Margin = new System.Windows.Forms.Padding(5);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(200, 36);
            this.isbnText.TabIndex = 2;
            this.isbnText.TextChanged += new System.EventHandler(this.isbnText_TextChanged);
            // 
            // Publisher
            // 
            this.Publisher.AccessibleName = "";
            this.Publisher.AutoSize = true;
            this.Publisher.Location = new System.Drawing.Point(53, 297);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(113, 27);
            this.Publisher.TabIndex = 14;
            this.Publisher.Text = "Publisher";
            // 
            // publish
            // 
            this.publish.BackColor = System.Drawing.Color.White;
            this.publish.Location = new System.Drawing.Point(249, 297);
            this.publish.Margin = new System.Windows.Forms.Padding(5);
            this.publish.Name = "publish";
            this.publish.Size = new System.Drawing.Size(200, 36);
            this.publish.TabIndex = 3;
            this.publish.TextChanged += new System.EventHandler(this.publish_TextChanged);
            // 
            // publishDate
            // 
            this.publishDate.AccessibleName = "";
            this.publishDate.AutoSize = true;
            this.publishDate.Location = new System.Drawing.Point(53, 366);
            this.publishDate.Name = "publishDate";
            this.publishDate.Size = new System.Drawing.Size(188, 27);
            this.publishDate.TabIndex = 16;
            this.publishDate.Text = "Publishing Date";
            // 
            // bookTitle
            // 
            this.bookTitle.AccessibleName = "";
            this.bookTitle.AutoSize = true;
            this.bookTitle.Location = new System.Drawing.Point(53, 179);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(119, 27);
            this.bookTitle.TabIndex = 18;
            this.bookTitle.Text = "Book Title";
            this.bookTitle.Click += new System.EventHandler(this.bookTitle_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(249, 170);
            this.title.Margin = new System.Windows.Forms.Padding(5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 36);
            this.title.TabIndex = 1;
            // 
            // price
            // 
            this.price.AccessibleName = "";
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(53, 435);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(69, 27);
            this.price.TabIndex = 20;
            this.price.Text = "Price";
            this.price.Click += new System.EventHandler(this.label5_Click);
            // 
            // addBookBtn
            // 
            this.addBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(114)))), ((int)(((byte)(175)))));
            this.addBookBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBookBtn.Location = new System.Drawing.Point(387, 585);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(159, 51);
            this.addBookBtn.TabIndex = 7;
            this.addBookBtn.Text = "Add Book";
            this.addBookBtn.UseVisualStyleBackColor = false;
            this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(186, 591);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(97, 39);
            this.clear.TabIndex = 22;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // isbnNotValid
            // 
            this.isbnNotValid.AutoSize = true;
            this.isbnNotValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnNotValid.ForeColor = System.Drawing.Color.Red;
            this.isbnNotValid.Location = new System.Drawing.Point(471, 240);
            this.isbnNotValid.Name = "isbnNotValid";
            this.isbnNotValid.Size = new System.Drawing.Size(246, 21);
            this.isbnNotValid.TabIndex = 24;
            this.isbnNotValid.Text = "ISBN not valid (letters found)";
            this.isbnNotValid.Click += new System.EventHandler(this.isbnNotValid_Click);
            // 
            // publisherNotValid
            // 
            this.publisherNotValid.AutoSize = true;
            this.publisherNotValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherNotValid.ForeColor = System.Drawing.Color.Red;
            this.publisherNotValid.Location = new System.Drawing.Point(471, 303);
            this.publisherNotValid.Name = "publisherNotValid";
            this.publisherNotValid.Size = new System.Drawing.Size(160, 21);
            this.publisherNotValid.TabIndex = 25;
            this.publisherNotValid.Text = "Publisher not valid";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(249, 366);
            this.dateTime.MaxDate = new System.DateTime(2024, 5, 11, 0, 0, 0, 0);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(399, 36);
            this.dateTime.TabIndex = 4;
            this.dateTime.Value = new System.DateTime(2024, 5, 11, 0, 0, 0, 0);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(249, 502);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 35);
            this.categoryBox.TabIndex = 6;
            // 
            // category
            // 
            this.category.AccessibleName = "";
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(53, 505);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(120, 27);
            this.category.TabIndex = 28;
            this.category.Text = "Category";
            // 
            // isbnValid
            // 
            this.isbnValid.AutoSize = true;
            this.isbnValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnValid.ForeColor = System.Drawing.Color.Green;
            this.isbnValid.Location = new System.Drawing.Point(471, 240);
            this.isbnValid.Name = "isbnValid";
            this.isbnValid.Size = new System.Drawing.Size(92, 21);
            this.isbnValid.TabIndex = 30;
            this.isbnValid.Text = "ISBN valid";
            this.isbnValid.Click += new System.EventHandler(this.isbnValid_Click);
            // 
            // publisherValid
            // 
            this.publisherValid.AutoSize = true;
            this.publisherValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherValid.ForeColor = System.Drawing.Color.Green;
            this.publisherValid.Location = new System.Drawing.Point(471, 303);
            this.publisherValid.Name = "publisherValid";
            this.publisherValid.Size = new System.Drawing.Size(129, 21);
            this.publisherValid.TabIndex = 31;
            this.publisherValid.Text = "Publisher Valid";
            this.publisherValid.Click += new System.EventHandler(this.publisherValid_Click);
            // 
            // priceSelect
            // 
            this.priceSelect.Location = new System.Drawing.Point(249, 435);
            this.priceSelect.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.priceSelect.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceSelect.Name = "priceSelect";
            this.priceSelect.Size = new System.Drawing.Size(120, 36);
            this.priceSelect.TabIndex = 5;
            this.priceSelect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // maxPrice
            // 
            this.maxPrice.AutoSize = true;
            this.maxPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.maxPrice.Location = new System.Drawing.Point(413, 441);
            this.maxPrice.Name = "maxPrice";
            this.maxPrice.Size = new System.Drawing.Size(133, 21);
            this.maxPrice.TabIndex = 34;
            this.maxPrice.Text = "max price 5000";
            // 
            // addBookValid
            // 
            this.addBookValid.AutoSize = true;
            this.addBookValid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookValid.ForeColor = System.Drawing.Color.Red;
            this.addBookValid.Location = new System.Drawing.Point(320, 639);
            this.addBookValid.Name = "addBookValid";
            this.addBookValid.Size = new System.Drawing.Size(293, 21);
            this.addBookValid.TabIndex = 35;
            this.addBookValid.Text = "Please complete all required fields";
            // 
            // addBookAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(755, 707);
            this.Controls.Add(this.addBookValid);
            this.Controls.Add(this.maxPrice);
            this.Controls.Add(this.priceSelect);
            this.Controls.Add(this.publisherValid);
            this.Controls.Add(this.isbnValid);
            this.Controls.Add(this.category);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.publisherNotValid);
            this.Controls.Add(this.isbnNotValid);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addBookBtn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.bookTitle);
            this.Controls.Add(this.title);
            this.Controls.Add(this.publishDate);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.publish);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "addBookAdmin";
            this.Text = "addBookAdmin";
            this.Load += new System.EventHandler(this.addBookAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.TextBox publish;
        private System.Windows.Forms.Label publishDate;
        private System.Windows.Forms.Label bookTitle;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label isbnNotValid;
        private System.Windows.Forms.Label publisherNotValid;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label isbnValid;
        private System.Windows.Forms.Label publisherValid;
        private System.Windows.Forms.NumericUpDown priceSelect;
        private System.Windows.Forms.Label maxPrice;
        private System.Windows.Forms.Label addBookValid;
    }
}