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
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class borrowBook : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IJ8RCOH\SQLEXPRESS01;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False");
        public borrowBook()
        {
            InitializeComponent();
            IsbnNotCorrect.Visible = false;
            usernameNotValid.Visible = false;
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void IsbnNotCorrect_Click(object sender, EventArgs e)
        {

        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {
            foreach(char c in isbnText.Text)
            {
                if (char.IsLetter(c))
                {
                    IsbnNotCorrect.Visible = true;
                    return;
                }
            }
            IsbnNotCorrect.Visible = false;
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {
            usernameNotValid.Visible = false;
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            string userID, bookISBN;
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUserId = $"SELECT USER_ID FROM STUDENT WHERE USERNAME = '{usernameText.Text}';";


                    // Getting user ID from the username that he added.
                    using (SqlCommand cmd = new SqlCommand(checkUserId, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        // If username not found (number of resulted rows = 0) then display that username not found
                        if (table.Rows.Count == 0)
                        {
                            usernameNotValid.Visible = true;
                            // return;
                        }
                        else // Else store it in userID variable
                        {
                            DataRow firstRow = table.Rows[0];
                            userID = firstRow["USER_ID"].ToString();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally { connect.Close(); }
            }
        }
    }
}
