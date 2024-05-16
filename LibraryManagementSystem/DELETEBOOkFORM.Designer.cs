namespace WindowsFormsApp2
{
    partial class Form1
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
            this.deletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.deletebtn.Location = new System.Drawing.Point(330, 399);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(155, 39);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete Book";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.dataGridView1.Location = new System.Drawing.Point(134, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 244);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dleate Book Form";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.searchbtn.Location = new System.Drawing.Point(553, 80);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(141, 33);
            this.searchbtn.TabIndex = 5;
            this.searchbtn.Text = "Search ";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox1.Location = new System.Drawing.Point(300, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 32);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(129, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter ISBN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(226)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(45)))), ((int)(((byte)(78)))));
            this.Name = "Form1";
            this.Text = "Delete Form 1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

