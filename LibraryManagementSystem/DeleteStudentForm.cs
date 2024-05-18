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

namespace LibraryManagementSystem
{
    public partial class DeleteStudentForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\LibraryManagementSystem\LibraryManagementSystem\LIBRARY_DB.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\Study\DataBase\LibraryManagementSystem-master\LibraryManagementSystem-master\LibraryManagementSystem\LIBR_DB.mdf;Integrated Security = True");
        ConnectionState state = ConnectionState.Open;

        public DeleteStudentForm()
        {
            InitializeComponent();
            //conn = new SqlConnection(sql); // Initialize the SqlConnection object
        }
        private void DeleteStudentForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadUsertable();
            

        }
        public DataTable LoadUsertable()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM [USER]";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM [USER] WHERE USERNAME = @username";


                // Using parameterized query to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", textBox2.Text);
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
                    MessageBox.Show("No user found with the given user ID.");
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        // Delete related records from BORROW table
                        string deleteBorrowQuery = "DELETE FROM BORROW WHERE USER_ID = @userid";
                        SqlCommand deleteBorrowCmd = new SqlCommand(deleteBorrowQuery, conn);
                        deleteBorrowCmd.Parameters.AddWithValue("@userid", dataGridView1.CurrentRow.Cells["USER_ID"].Value.ToString());
                        deleteBorrowCmd.ExecuteNonQuery();

                        // Delete related records from STUDENT table
                        string deleteStudentsQuery = "DELETE FROM STUDENT WHERE USER_ID = @userid";
                        SqlCommand deleteStudentsCmd = new SqlCommand(deleteStudentsQuery, conn);
                        deleteStudentsCmd.Parameters.AddWithValue("@userid", dataGridView1.CurrentRow.Cells["USER_ID"].Value.ToString());
                        deleteStudentsCmd.ExecuteNonQuery();

                        // Delete record from USER table
                        string deleteUserQuery = "DELETE FROM [USER] WHERE USER_ID = @userid";
                        SqlCommand deleteUserCmd = new SqlCommand(deleteUserQuery, conn);
                        deleteUserCmd.Parameters.AddWithValue("@userid", dataGridView1.CurrentRow.Cells["USER_ID"].Value.ToString());
                        deleteUserCmd.ExecuteNonQuery();

                        conn.Close();
                        MessageBox.Show("User deleted successfully");

                        // Refresh DataGridView by re-loading data
                        dataGridView1.DataSource = LoadUsertable();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
