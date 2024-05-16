using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnisbn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-QKA3DLB; Database=LIBR_DB; Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuerySelect = "SELECT * FROM  BOOK where ISBN=" + textBox1.Text + " ";

            SqlCommand command = new SqlCommand(sqlQuerySelect, con);
            var reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
             string connectionString = "Server=DESKTOP-QKA3DLB; Database=LIBR_DB; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string sqlQuerySelect = "SELECT * FROM  BOOK WHERE TITLE = @Title";

                    SqlCommand command = new SqlCommand(sqlQuerySelect, con);
                    command.Parameters.AddWithValue("@Title", textBox3.Text);

                    SqlDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnpubisher_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-QKA3DLB; Database=LIBR_DB; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sqlQuerySelect = "SELECT * FROM BOOK WHERE PUBLISHER = @Publisher";

                SqlCommand command = new SqlCommand(sqlQuerySelect, con);
                command.Parameters.AddWithValue("@Publisher", textBox2.Text);

                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
