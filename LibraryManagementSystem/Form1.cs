using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tSearch_Click(object sender, EventArgs e)
        { 
        }
        //search by isbn
        private void btnSearch_Click(object sender, EventArgs e)
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
    }
}
