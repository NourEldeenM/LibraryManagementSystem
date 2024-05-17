namespace WindowsFormsApp2
{
    partial class DELETEBOOkFORM
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
            deletebtn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            searchbtn = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deletebtn
            // 
            deletebtn.Font = new Font("Microsoft Sans Serif", 16F);
            deletebtn.Location = new Point(385, 460);
            deletebtn.Margin = new Padding(4, 3, 4, 3);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(181, 45);
            deletebtn.TabIndex = 2;
            deletebtn.Text = "Delete Book";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(249, 247, 247);
            dataGridView1.Location = new Point(156, 155);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(653, 282);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.Location = new Point(344, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 0;
            label1.Text = "Delete Book Form";
            label1.Click += label1_Click;
            // 
            // searchbtn
            // 
            searchbtn.Font = new Font("Microsoft Sans Serif", 16F);
            searchbtn.Location = new Point(645, 92);
            searchbtn.Margin = new Padding(4, 3, 4, 3);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(164, 38);
            searchbtn.TabIndex = 5;
            searchbtn.Text = "Search ";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 16F);
            textBox1.Location = new Point(350, 93);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 32);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.Location = new Point(150, 97);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 7;
            label2.Text = "Enter ISBN";
            // 
            // DELETEBOOkFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(219, 226, 239);
            ClientSize = new Size(933, 532);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(deletebtn);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(17, 45, 78);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DELETEBOOkFORM";
            Text = "Delete Form 1";
            TransparencyKey = Color.FromArgb(249, 247, 247);
            Load += DELETEBOOkFORM_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}


