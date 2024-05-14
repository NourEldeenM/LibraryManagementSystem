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
            this.Label1 = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.ISBNVal = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.Label();
            this.publisherval = new System.Windows.Forms.TextBox();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.Authorvar = new System.Windows.Forms.TextBox();
            this.PDate = new System.Windows.Forms.Label();
            this.PDateval = new System.Windows.Forms.DateTimePicker();
            this.priceL = new System.Windows.Forms.Label();
            this.PriceVal = new System.Windows.Forms.DomainUpDown();
            this.category = new System.Windows.Forms.Label();
            this.categoryval = new System.Windows.Forms.ComboBox();
            this.UpdateBookBtn = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Label1
            //
            this.Label1.AutoSize =  true;
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.Text =  "Update Book";
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(364,12);
            this.Label1.Size = new System.Drawing.Size(96,20);
            this.Label1.TabIndex = 1;
            //
            // BookTitle
            //
            this.BookTitle.AutoSize =  true;
            this.BookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BookTitle.Text =  "Book Title";
            this.BookTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookTitle.Location = new System.Drawing.Point(32,76);
            this.BookTitle.Size = new System.Drawing.Size(76,20);
            this.BookTitle.TabIndex = 2;
            //
            // Title
            //
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(157,78);
            this.Title.Size = new System.Drawing.Size(168,27);
            this.Title.TabIndex = 3;
            
            //
            // ISBN
            //
            this.ISBN.AutoSize =  true;
            this.ISBN.Text =  "ISBN";
            this.ISBN.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ISBN.Location = new System.Drawing.Point(36,136);
            this.ISBN.Size = new System.Drawing.Size(41,20);
            this.ISBN.TabIndex = 4;
            //
            // ISBNVal
            //
            this.ISBNVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ISBNVal.Location = new System.Drawing.Point(156,132);
            this.ISBNVal.Size = new System.Drawing.Size(168,27);
            this.ISBNVal.TabIndex = 5;
            //
            // publisher
            //
            this.publisher.AutoSize =  true;
            this.publisher.Text =  "publisher";
            this.publisher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisher.Location = new System.Drawing.Point(36,196);
            this.publisher.Size = new System.Drawing.Size(70,20);
            this.publisher.TabIndex = 6;
            //
            // publisherval
            //
            this.publisherval.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.publisherval.Location = new System.Drawing.Point(156,196);
            this.publisherval.Size = new System.Drawing.Size(168,27);
            this.publisherval.TabIndex = 7;
            //
            // AuthorLabel
            //
            this.AuthorLabel.AutoSize =  true;
            this.AuthorLabel.Text =  "Author";
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLabel.Location = new System.Drawing.Point(36,248);
            this.AuthorLabel.Size = new System.Drawing.Size(54,20);
            this.AuthorLabel.TabIndex = 8;
            //
            // Authorvar
            //
            this.Authorvar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Authorvar.Location = new System.Drawing.Point(156,248);
            this.Authorvar.Size = new System.Drawing.Size(168,27);
            this.Authorvar.TabIndex = 9;
            //
            // PDate
            //
            this.PDate.AutoSize =  true;
            this.PDate.Text =  "Publishing Date";
            this.PDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDate.Location = new System.Drawing.Point(404,200);
            this.PDate.Size = new System.Drawing.Size(113,20);
            this.PDate.TabIndex = 10;
            //
            // PDateval
            //
            this.PDateval.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDateval.Text =  "2024 ,مايو 14";
            this.PDateval.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PDateval.Location = new System.Drawing.Point(560,196);
            this.PDateval.Size = new System.Drawing.Size(200,27);
            this.PDateval.TabIndex = 13;
            //
            // priceL
            //
            this.priceL.AutoSize =  true;
            this.priceL.Text =  "Price";
            this.priceL.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.priceL.Location = new System.Drawing.Point(36,312);
            this.priceL.Size = new System.Drawing.Size(41,20);
            this.priceL.TabIndex = 14;
            //
            // PriceVal
            //
            this.PriceVal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceVal.Location = new System.Drawing.Point(156,312);
            this.PriceVal.Size = new System.Drawing.Size(120,27);
            this.PriceVal.TabIndex = 16;
            //
            // category
            //
            this.category.AutoSize =  true;
            this.category.Text =  "Category";
            this.category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.category.Location = new System.Drawing.Point(36,388);
            this.category.Size = new System.Drawing.Size(69,20);
            this.category.TabIndex = 17;
            //
            // categoryval
            //
            this.categoryval.ItemHeight = 20;
            this.categoryval.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryval.Location = new System.Drawing.Point(152,384);
            this.categoryval.Size = new System.Drawing.Size(121,28);
            this.categoryval.TabIndex = 19;
            //
            // UpdateBookBtn
            //
            this.UpdateBookBtn.BackColor = System.Drawing.Color.FromArgb(75, 114, 175);
            this.UpdateBookBtn.Text =  "Update Book";
            this.UpdateBookBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateBookBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBookBtn.Location = new System.Drawing.Point(568,444);
            this.UpdateBookBtn.Size = new System.Drawing.Size(119,39);
            this.UpdateBookBtn.TabIndex = 21;
            this.UpdateBookBtn.Click += new System.EventHandler(this.UpdateBookBtn_Click);
            // 
            //
            // Clear
            //
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Text =  "Clear";
            this.Clear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(188,448);
            this.Clear.Size = new System.Drawing.Size(112,36);
            this.Clear.TabIndex = 22;
            this.Clear.Click += new System.EventHandler(this.clear_click);
         //
         // form
         //
            this.AutoScaleBaseSize = new System.Drawing.Size(7,20);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(865,545);
            this.Text =  "Form1";
            this.AutoScrollMargin = new System.Drawing.Size(16,13);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.ISBNVal);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.publisherval);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.Authorvar);
            this.Controls.Add(this.PDate);
            this.Controls.Add(this.PDateval);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.PriceVal);
            this.Controls.Add(this.category);
            this.Controls.Add(this.categoryval);
            this.Controls.Add(this.UpdateBookBtn);
            this.Controls.Add(this.Clear);
            this.ResumeLayout(false);
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
    }
}

