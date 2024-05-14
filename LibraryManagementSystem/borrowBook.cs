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
    public partial class borrowBook : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IJ8RCOH\SQLEXPRESS01;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False");
        public borrowBook()
        {
            InitializeComponent();
            IsbnNotCorrect.Visible = false;
            usernameNotValid.Visible = false;
            isbnNotFound.Visible = false;
            bookFinished.Visible = false;
            IsbnNotCorrect.Visible = false;
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void IsbnNotCorrect_Click(object sender, EventArgs e)
        {

        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in isbnText.Text)
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

        private void borrowBook_Load(object sender, EventArgs e)
        {

        }

        private void isbnNotFound_Click(object sender, EventArgs e)
        {

        }

        private void bookFinished_Click(object sender, EventArgs e)
        {

        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            /*
             Step1: Check that ISBN is a Valid number
             */
            if (IsbnNotCorrect.Visible == true)
                return;
            isbnNotFound.Visible = false;
            bookFinished.Visible = false;
            string userid = "", bookISBN, copyID;

            /*
             Step2: Establish Connection With Database
             */
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string checkUserId = $"SELECT * FROM STUDENT WHERE USERNAME = '{usernameText.Text}';";
                    /*
                     Step3: Go To Student Table and get USER_ID of the USER_NAME that he entered
                     */
                    SqlCommand cmd = new SqlCommand(checkUserId, connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    /*
                     Step4: If username not found (number of resulted rows = 0) then display that username not found
                     */
                    if (table.Rows.Count == 0)
                        usernameNotValid.Visible = true;
                    else // Else store it in userID variable
                    {
                        DataRow firstRow = table.Rows[0];
                        userid = firstRow["USER_ID"].ToString();
                    }


                    string checkBookISBN = $"SELECT * FROM BOOKCOPY WHERE ISBN = {isbnText.Text};";
                    /* 
                     * Step5: Checking that book ISBN is found in book copies
                    */
                    cmd = new SqlCommand(checkBookISBN, connect);
                    adapter = new SqlDataAdapter(cmd);
                    table = new DataTable();
                    adapter.Fill(table);
                    /*
                     * Step6: If book ISBN not found in book copies display that ISBN maybe wrong or book is missing
                    */
                    if (table.Rows.Count == 0)
                        isbnNotFound.Visible = true;
                    else // Means that book with that ISBN is found
                    {
                        DataRow firstRow = table.Rows[0];
                        string temp = firstRow["NUM_OF_COPIES"].ToString();
                        int num_copies = int.Parse(temp);
                        /* 
                         * Step7: Check that the number of copies of that book greater than 0 so he can take one
                         * then minus one from the number of copies.
                        */
                        if (num_copies > 0)
                        {
                            bookISBN = firstRow["ISBN"].ToString();
                            string checkUserBorrowedAlready = $"SELECT * FROM BORROW WHERE USER_ID = {userid} AND ISBN = {bookISBN};";
                            cmd = new SqlCommand(checkUserBorrowedAlready, connect);
                            cmd.ExecuteNonQuery();
                            adapter = new SqlDataAdapter(cmd);
                            table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count == 0)
                            {
                                int newNumCopies = num_copies - 1;
                                string minusOne = $"UPDATE BOOKCOPY SET NUM_OF_COPIES = {newNumCopies} WHERE ISBN = {bookISBN};";
                                cmd = new SqlCommand(minusOne, connect);
                                cmd.ExecuteNonQuery();


                                /*
                                Step8: add user_id & isbn to table borrow
                                */
                                copyID = firstRow["COPY_ID"].ToString();
                                string addUserToBorrow = $"INSERT INTO BORROW(USER_ID, ISBN, COPY_ID) VALUES({userid}, {bookISBN}, {copyID});";
                                cmd = new SqlCommand(addUserToBorrow, connect);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Success! Book was borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Book already in your borrow list", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else // Num of copies == 0
                            bookFinished.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }

            }
        }
    }
}
