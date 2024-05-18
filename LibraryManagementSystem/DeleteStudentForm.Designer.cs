namespace LibraryManagementSystem
{
    partial class DeleteStudentForm    {
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            searchbtn = new Button();
            deletebtn = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 45, 78);
            label1.Location = new Point(44, 279);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 24);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(17, 45, 78);
            label2.Location = new Point(13, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(481, 165);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(439, 314);
            dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 16F);
            textBox1.Location = new Point(118, 271);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 32);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Microsoft Sans Serif", 16F);
            searchbtn.ForeColor = SystemColors.MenuHighlight;
            searchbtn.Location = new Point(259, 337);
            searchbtn.Margin = new Padding(4, 3, 4, 3);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(121, 42);
            searchbtn.TabIndex = 4;
            searchbtn.Text = "search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Microsoft Sans Serif", 16F);
            deletebtn.Location = new Point(79, 337);
            deletebtn.Margin = new Padding(4, 3, 4, 3);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(121, 42);
            deletebtn.TabIndex = 5;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 16F);
            textBox2.Location = new Point(118, 207);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 32);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(17, 45, 78);
            label3.Location = new Point(88, 66);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(267, 33);
            label3.TabIndex = 7;
            label3.Text = "Delete Studnt Form";
            label3.Click += label3_Click;
            // 
            // DeleteStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(933, 519);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(deletebtn);
            Controls.Add(searchbtn);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeleteStudentForm";
            Text = "Form1";
            Load += DeleteStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}
