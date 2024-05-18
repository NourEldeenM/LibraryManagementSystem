namespace LibraryManagmentSystem
{
    partial class UpdateBookForm
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
            Backlink = new LinkLabel();
            Label1 = new Label();
            BookTitle = new Label();
            Title = new TextBox();
            ISBN = new Label();
            ISBNVal = new TextBox();
            publisher = new Label();
            publisherval = new TextBox();
            AuthorLabel = new Label();
            Authorvar = new TextBox();
            PDate = new Label();
            PDateval = new DateTimePicker();
            priceL = new Label();
            PriceVal = new DomainUpDown();
            category = new Label();
            categoryval = new ComboBox();
            UpdateBookBtn = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // Backlink
            // 
            Backlink.AutoSize = true;
            Backlink.LinkColor = Color.Black;
            Backlink.Location = new Point(12, 12);
            Backlink.Name = "Backlink";
            Backlink.Size = new Size(50, 15);
            Backlink.TabIndex = 0;
            Backlink.TabStop = true;
            Backlink.Text = "Go Back";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.FromArgb(17, 45, 78);
            Label1.Location = new Point(298, 29);
            Label1.Name = "Label1";
            Label1.Size = new Size(172, 37);
            Label1.TabIndex = 1;
            Label1.Text = "Update Book";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            Label1.Click += Label1_Click;
            // 
            // BookTitle
            // 
            BookTitle.AutoSize = true;
            BookTitle.Font = new Font("Microsoft Sans Serif", 12.75F);
            BookTitle.ForeColor = Color.FromArgb(17, 45, 78);
            BookTitle.Location = new Point(34, 149);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(84, 20);
            BookTitle.TabIndex = 2;
            BookTitle.Text = "Book Title";
            BookTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            Title.BackColor = SystemColors.ControlLightLight;
            Title.Font = new Font("Segoe UI", 11F);
            Title.Location = new Point(159, 146);
            Title.Name = "Title";
            Title.Size = new Size(168, 27);
            Title.TabIndex = 3;
            // 
            // ISBN
            // 
            ISBN.AutoSize = true;
            ISBN.Font = new Font("Microsoft Sans Serif", 12.75F);
            ISBN.ForeColor = Color.FromArgb(17, 45, 78);
            ISBN.Location = new Point(38, 200);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(48, 20);
            ISBN.TabIndex = 4;
            ISBN.Text = "ISBN";
            // 
            // ISBNVal
            // 
            ISBNVal.Font = new Font("Segoe UI", 11F);
            ISBNVal.Location = new Point(158, 196);
            ISBNVal.Name = "ISBNVal";
            ISBNVal.Size = new Size(168, 27);
            ISBNVal.TabIndex = 5;
            // 
            // publisher
            // 
            publisher.AutoSize = true;
            publisher.Font = new Font("Microsoft Sans Serif", 12.75F);
            publisher.ForeColor = Color.FromArgb(17, 45, 78);
            publisher.Location = new Point(38, 252);
            publisher.Name = "publisher";
            publisher.Size = new Size(77, 20);
            publisher.TabIndex = 6;
            publisher.Text = "publisher";
            // 
            // publisherval
            // 
            publisherval.Font = new Font("Segoe UI", 11F);
            publisherval.Location = new Point(158, 252);
            publisherval.Name = "publisherval";
            publisherval.Size = new Size(168, 27);
            publisherval.TabIndex = 7;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Font = new Font("Microsoft Sans Serif", 12.75F);
            AuthorLabel.ForeColor = Color.FromArgb(17, 45, 78);
            AuthorLabel.Location = new Point(38, 306);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(58, 20);
            AuthorLabel.TabIndex = 8;
            AuthorLabel.Text = "Author";
            // 
            // Authorvar
            // 
            Authorvar.Font = new Font("Segoe UI", 11F);
            Authorvar.Location = new Point(158, 306);
            Authorvar.Name = "Authorvar";
            Authorvar.Size = new Size(168, 27);
            Authorvar.TabIndex = 9;
            // 
            // PDate
            // 
            PDate.AutoSize = true;
            PDate.Font = new Font("Microsoft Sans Serif", 12.75F);
            PDate.ForeColor = Color.FromArgb(17, 45, 78);
            PDate.Location = new Point(404, 187);
            PDate.Name = "PDate";
            PDate.Size = new Size(127, 20);
            PDate.TabIndex = 10;
            PDate.Text = "Publishing Date";
            // 
            // PDateval
            // 
            PDateval.CalendarFont = new Font("Segoe UI", 11F);
            PDateval.Font = new Font("Segoe UI", 11F);
            PDateval.Location = new Point(560, 183);
            PDateval.Name = "PDateval";
            PDateval.Size = new Size(200, 27);
            PDateval.TabIndex = 13;
            // 
            // priceL
            // 
            priceL.AutoSize = true;
            priceL.Font = new Font("Microsoft Sans Serif", 12.75F);
            priceL.ForeColor = Color.FromArgb(17, 45, 78);
            priceL.Location = new Point(434, 308);
            priceL.Name = "priceL";
            priceL.Size = new Size(48, 20);
            priceL.TabIndex = 14;
            priceL.Text = "Price";
            priceL.Click += this.priceL_Click;
            // 
            // PriceVal
            // 
            PriceVal.Font = new Font("Segoe UI", 11F);
            PriceVal.Location = new Point(554, 308);
            PriceVal.Name = "PriceVal";
            PriceVal.Size = new Size(206, 27);
            PriceVal.TabIndex = 16;
            PriceVal.SelectedItemChanged += PriceVal_SelectedItemChanged;
            // 
            // category
            // 
            category.AutoSize = true;
            category.Font = new Font("Microsoft Sans Serif", 12.75F);
            category.ForeColor = Color.FromArgb(17, 45, 78);
            category.Location = new Point(424, 246);
            category.Name = "category";
            category.Size = new Size(76, 20);
            category.TabIndex = 17;
            category.Text = "Category";
            // 
            // categoryval
            // 
            categoryval.Font = new Font("Segoe UI", 11F);
            categoryval.ItemHeight = 20;
            categoryval.Location = new Point(555, 243);
            categoryval.Name = "categoryval";
            categoryval.Size = new Size(205, 28);
            categoryval.TabIndex = 19;
            // 
            // UpdateBookBtn
            // 
            UpdateBookBtn.BackColor = Color.FromArgb(75, 114, 175);
            UpdateBookBtn.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBookBtn.ForeColor = Color.White;
            UpdateBookBtn.Location = new Point(465, 381);
            UpdateBookBtn.Name = "UpdateBookBtn";
            UpdateBookBtn.Size = new Size(119, 39);
            UpdateBookBtn.TabIndex = 21;
            UpdateBookBtn.Text = "Update Book";
            UpdateBookBtn.UseVisualStyleBackColor = false;
            UpdateBookBtn.Click += UpdateBookBtn_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.White;
            Clear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Clear.ForeColor = Color.FromArgb(17, 45, 78);
            Clear.Location = new Point(280, 384);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 36);
            Clear.TabIndex = 22;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += clear_click;
            // 
            // UpdateBookForm
            // 
            AutoScaleBaseSize = new Size(7, 20);
            AutoScrollMargin = new Size(16, 13);
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(798, 443);
            Controls.Add(Label1);
            Controls.Add(BookTitle);
            Controls.Add(Title);
            Controls.Add(ISBN);
            Controls.Add(ISBNVal);
            Controls.Add(publisher);
            Controls.Add(publisherval);
            Controls.Add(AuthorLabel);
            Controls.Add(Authorvar);
            Controls.Add(PDate);
            Controls.Add(PDateval);
            Controls.Add(priceL);
            Controls.Add(PriceVal);
            Controls.Add(category);
            Controls.Add(categoryval);
            Controls.Add(UpdateBookBtn);
            Controls.Add(Clear);
            Font = new Font("Segoe UI", 11F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UpdateBookForm";
            Text = "Form1";
            Load += UpdateBookForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox ISBNVal;
        private System.Windows.Forms.Label publisher;
        private System.Windows.Forms.TextBox publisherval;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox Authorvar;
        private System.Windows.Forms.Label PDate;
        private System.Windows.Forms.DateTimePicker PDateval;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.DomainUpDown PriceVal;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.ComboBox categoryval;
        private System.Windows.Forms.Button UpdateBookBtn;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.LinkLabel Backlink;
    }
}


