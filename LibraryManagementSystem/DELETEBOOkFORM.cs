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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        String sql = "Data Source=NADRASAAD\\SQLEXPRESS;Initial Catalog=LIBRARY_DB;Integrated Security=True";

        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(sql); // Initialize the SqlConnection object
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Loadbooktable();
        }

        public DataTable Loadbooktable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BOOK";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // This method doesn't have any functionality, you can remove it if not needed.
        }


        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM BOOK WHERE ISBN = @isbn";

                // Using parameterized query to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", textBox1.Text);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                conn.Close();

                // Checking if any rows are returned before binding to DataGridView
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No book found with the given ISBN.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        // Delete related records from WRITTEN_BY table
                        string deleteWrittenByQuery = "DELETE FROM WRITTEN_BY WHERE ISBN = @isbn";
                        SqlCommand deleteWrittenByCmd = new SqlCommand(deleteWrittenByQuery, conn);
                        deleteWrittenByCmd.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString());
                        deleteWrittenByCmd.ExecuteNonQuery();

                        // Delete related records from BOOKCOPY table
                        string deleteCopiesQuery = "DELETE FROM BOOKCOPY WHERE ISBN = @isbn";
                        SqlCommand deleteCopiesCmd = new SqlCommand(deleteCopiesQuery, conn);
                        deleteCopiesCmd.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString());
                        deleteCopiesCmd.ExecuteNonQuery();

                        // Delete record from BOOK table
                        string deleteBookQuery = "DELETE FROM BOOK WHERE ISBN = @isbn";
                        SqlCommand deleteBookCmd = new SqlCommand(deleteBookQuery, conn);
                        deleteBookCmd.Parameters.AddWithValue("@isbn", dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString());
                        deleteBookCmd.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("Book deleted successfully");

                        // Refresh DataGridView by re-loading data
                        dataGridView1.DataSource = Loadbooktable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
