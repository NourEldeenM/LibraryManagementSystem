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
            panel1 = new Panel();
            label2 = new Label();
            ISBN = new Label();
            isbnText = new TextBox();
            Publisher = new Label();
            publish = new TextBox();
            publishDate = new Label();
            bookTitle = new Label();
            title = new TextBox();
            price = new Label();
            addBookBtn = new Button();
            clear = new Button();
            isbnNotValid = new Label();
            publisherNotValid = new Label();
            dateTime = new DateTimePicker();
            categoryBox = new ComboBox();
            category = new Label();
            isbnValid = new Label();
            publisherValid = new Label();
            priceSelect = new NumericUpDown();
            maxPrice = new Label();
            addBookValid = new Label();
            label1 = new Label();
            bookCopyBox = new TextBox();
            label3 = new Label();
            authorID = new TextBox();
            label4 = new Label();
            author = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceSelect).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 45, 78);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(16, 13, 16, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 72);
            panel1.TabIndex = 2;
           // panel1.Paint += panel1_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 27);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 9;
            label2.Text = "Add Book";
            label2.Click += label2_Click;
            // 
            // ISBN
            // 
            ISBN.AccessibleName = "";
            ISBN.AutoSize = true;
            ISBN.Location = new Point(53, 234);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(49, 22);
            ISBN.TabIndex = 12;
            ISBN.Text = "ISBN";
            // 
            // isbnText
            // 
            isbnText.BackColor = Color.White;
            isbnText.Location = new Point(249, 231);
            isbnText.Margin = new Padding(5);
            isbnText.Name = "isbnText";
            isbnText.Size = new Size(200, 30);
            isbnText.TabIndex = 2;
            isbnText.TextChanged += isbnText_TextChanged;
            // 
            // Publisher
            // 
            Publisher.AccessibleName = "";
            Publisher.AutoSize = true;
            Publisher.Location = new Point(53, 297);
            Publisher.Name = "Publisher";
            Publisher.Size = new Size(89, 22);
            Publisher.TabIndex = 14;
            Publisher.Text = "Publisher";
            // 
            // publish
            // 
            publish.BackColor = Color.White;
            publish.Location = new Point(249, 297);
            publish.Margin = new Padding(5);
            publish.Name = "publish";
            publish.Size = new Size(200, 30);
            publish.TabIndex = 3;
            publish.TextChanged += publish_TextChanged;
            // 
            // publishDate
            // 
            publishDate.AccessibleName = "";
            publishDate.AutoSize = true;
            publishDate.Location = new Point(53, 366);
            publishDate.Name = "publishDate";
            publishDate.Size = new Size(150, 22);
            publishDate.TabIndex = 16;
            publishDate.Text = "Publishing Date";
            // 
            // bookTitle
            // 
            bookTitle.AccessibleName = "";
            bookTitle.AutoSize = true;
            bookTitle.Location = new Point(53, 179);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(93, 22);
            bookTitle.TabIndex = 18;
            bookTitle.Text = "Book Title";
            bookTitle.Click += bookTitle_Click;
            // 
            // title
            // 
            title.BackColor = Color.White;
            title.Location = new Point(249, 179);
            title.Margin = new Padding(5);
            title.Name = "title";
            title.Size = new Size(200, 30);
            title.TabIndex = 1;
            // 
            // price
            // 
            price.AccessibleName = "";
            price.AutoSize = true;
            price.Location = new Point(53, 435);
            price.Name = "price";
            price.Size = new Size(54, 22);
            price.TabIndex = 20;
            price.Text = "Price";
            price.Click += label5_Click;
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = Color.FromArgb(63, 114, 175);
            addBookBtn.ForeColor = SystemColors.ButtonHighlight;
            addBookBtn.Location = new Point(544, 591);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(159, 51);
            addBookBtn.TabIndex = 7;
            addBookBtn.Text = "Add Book";
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // clear
            // 
            clear.Location = new Point(417, 597);
            clear.Name = "clear";
            clear.Size = new Size(97, 39);
            clear.TabIndex = 22;
            clear.Text = "clear";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // isbnNotValid
            // 
            isbnNotValid.AutoSize = true;
            isbnNotValid.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbnNotValid.ForeColor = Color.Red;
            isbnNotValid.Location = new Point(582, 240);
            isbnNotValid.Name = "isbnNotValid";
            isbnNotValid.Size = new Size(201, 19);
            isbnNotValid.TabIndex = 24;
            isbnNotValid.Text = "ISBN not valid (letters found)";
            isbnNotValid.Click += isbnNotValid_Click;
            // 
            // publisherNotValid
            // 
            publisherNotValid.AutoSize = true;
            publisherNotValid.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherNotValid.ForeColor = Color.Red;
            publisherNotValid.Location = new Point(623, 303);
            publisherNotValid.Name = "publisherNotValid";
            publisherNotValid.Size = new Size(134, 19);
            publisherNotValid.TabIndex = 25;
            publisherNotValid.Text = "Publisher not valid";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(249, 366);
            dateTime.MaxDate = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(399, 30);
            dateTime.TabIndex = 4;
            dateTime.Value = new DateTime(2024, 5, 11, 0, 0, 0, 0);
            // 
            // categoryBox
            // 
            categoryBox.FormattingEnabled = true;
            categoryBox.Location = new Point(249, 502);
            categoryBox.Name = "categoryBox";
            categoryBox.Size = new Size(121, 29);
            categoryBox.TabIndex = 6;
            // 
            // category
            // 
            category.AccessibleName = "";
            category.AutoSize = true;
            category.Location = new Point(53, 505);
            category.Name = "category";
            category.Size = new Size(99, 22);
            category.TabIndex = 28;
            category.Text = "Category";
            // 
            // isbnValid
            // 
            isbnValid.AutoSize = true;
            isbnValid.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isbnValid.ForeColor = Color.Green;
            isbnValid.Location = new Point(471, 240);
            isbnValid.Name = "isbnValid";
            isbnValid.Size = new Size(75, 19);
            isbnValid.TabIndex = 30;
            isbnValid.Text = "ISBN valid";
            isbnValid.Click += isbnValid_Click;
            // 
            // publisherValid
            // 
            publisherValid.AutoSize = true;
            publisherValid.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherValid.ForeColor = Color.Green;
            publisherValid.Location = new Point(471, 303);
            publisherValid.Name = "publisherValid";
            publisherValid.Size = new Size(108, 19);
            publisherValid.TabIndex = 31;
            publisherValid.Text = "Publisher Valid";
            publisherValid.Click += publisherValid_Click;
            // 
            // priceSelect
            // 
            priceSelect.Location = new Point(249, 435);
            priceSelect.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            priceSelect.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            priceSelect.Name = "priceSelect";
            priceSelect.Size = new Size(120, 30);
            priceSelect.TabIndex = 5;
            priceSelect.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // maxPrice
            // 
            maxPrice.AutoSize = true;
            maxPrice.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxPrice.ForeColor = Color.DarkSlateGray;
            maxPrice.Location = new Point(413, 441);
            maxPrice.Name = "maxPrice";
            maxPrice.Size = new Size(114, 19);
            maxPrice.TabIndex = 34;
            maxPrice.Text = "max price 5000";
            // 
            // addBookValid
            // 
            addBookValid.AutoSize = true;
            addBookValid.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookValid.ForeColor = Color.Red;
            addBookValid.Location = new Point(410, 657);
            addBookValid.Name = "addBookValid";
            addBookValid.Size = new Size(244, 19);
            addBookValid.TabIndex = 35;
            addBookValid.Text = "Please complete all required fields";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 561);
            label1.Name = "label1";
            label1.Size = new Size(111, 22);
            label1.TabIndex = 36;
            label1.Text = "Book Copy";
            // 
            // bookCopyBox
            // 
            bookCopyBox.Location = new Point(249, 558);
            bookCopyBox.Name = "bookCopyBox";
            bookCopyBox.Size = new Size(121, 30);
            bookCopyBox.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 130);
            label3.Name = "label3";
            label3.Size = new Size(98, 22);
            label3.TabIndex = 38;
            label3.Text = "Author ID";
            // 
            // authorID
            // 
            authorID.Location = new Point(249, 130);
            authorID.Name = "authorID";
            authorID.Size = new Size(200, 30);
            authorID.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 130);
            label4.Name = "label4";
            label4.Size = new Size(74, 22);
            label4.TabIndex = 40;
            label4.Text = "Author";
            // 
            // author
            // 
            author.Location = new Point(723, 121);
            author.Name = "author";
            author.Size = new Size(208, 30);
            author.TabIndex = 41;
            // 
            // addBookAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(992, 707);
            Controls.Add(author);
            Controls.Add(label4);
            Controls.Add(authorID);
            Controls.Add(label3);
            Controls.Add(bookCopyBox);
            Controls.Add(label1);
            Controls.Add(addBookValid);
            Controls.Add(maxPrice);
            Controls.Add(priceSelect);
            Controls.Add(publisherValid);
            Controls.Add(isbnValid);
            Controls.Add(category);
            Controls.Add(categoryBox);
            Controls.Add(dateTime);
            Controls.Add(publisherNotValid);
            Controls.Add(isbnNotValid);
            Controls.Add(clear);
            Controls.Add(addBookBtn);
            Controls.Add(price);
            Controls.Add(bookTitle);
            Controls.Add(title);
            Controls.Add(publishDate);
            Controls.Add(Publisher);
            Controls.Add(publish);
            Controls.Add(ISBN);
            Controls.Add(isbnText);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "addBookAdmin";
            Text = "addBookAdmin";
            Load += addBookAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookCopyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox author;
    }
}
