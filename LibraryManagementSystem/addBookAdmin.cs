using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace LibraryManagementSystem
{
    public partial class addBookAdmin : Form
    {
        public static string LoggedInUsername { get; set; }


        public addBookAdmin()
        {
            InitializeComponent();
            isbnValid.Visible = false;
            publisherValid.Visible = false;

            isbnNotValid.Visible = false;
            publisherNotValid.Visible = false;

            addBookValid.Visible = false;




        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bookTitle_Click(object sender, EventArgs e)
        {

        }

        private void addBookAdmin_Load(object sender, EventArgs e)
        {

        }

        private void isbnValid_Click(object sender, EventArgs e)
        {

        }

        private void priceNotValid_Click(object sender, EventArgs e)
        {

        }

        private void priceValid_Click(object sender, EventArgs e)
        {

        }

        private void publisherValid_Click(object sender, EventArgs e)
        {

        }

        private void isbnText_TextChanged(object sender, EventArgs e)
        {
            if (isbnText.TextLength == 0)
            {
                isbnNotValid.Visible = false;
                isbnValid.Visible = false;
                return;
            }
            foreach (char c in isbnText.Text)
            {
                if (char.IsLetter(c))
                {
                    isbnNotValid.Visible = true;
                    isbnValid.Visible = false;
                    return;
                }
            }
            isbnNotValid.Visible = false;
            isbnValid.Visible = true;
        }

        private void isbnNotValid_Click(object sender, EventArgs e)
        {

        }

        private void publish_TextChanged(object sender, EventArgs e)
        {
            // Here we should search for publisher name in table Author, if found, then display publisher valid.
            // Else display not valid.

            // For now I will make it valid but when adding the tables and connecting the database I will make the above statement
            if (publish.Text.Length == 0)
            {
                publisherValid.Visible = false;
                return;
            }
            publisherValid.Visible = true;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            isbnText.Clear();
            title.Clear();
            publish.Clear();
            dateTime.ResetText();
            priceSelect.ResetText();
            categoryBox.ResetText();
            bookCopyBox.Clear();
            authorID.Clear();
            author.Clear();

        }
        public int GetCategoryId()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mariam Omar\\Desktop\\LibraryManagementSystem\\LibraryManagementSystem\\LIBRARY_DB.mdf\";Integrated Security=True";
            //string connString = "Data Source=DESKTOP-09BU7VD\\SQLEXPRESS;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(@connString);
            conn.Open();
            int categoryId = -1;
            string getQuery = "select CATEGORY_ID from CATEGORY WHERE CATEGORY_NAME=@CATEGORY_NAME";
            SqlCommand cmmd = new SqlCommand(getQuery, conn);
            cmmd.Parameters.AddWithValue("@CATEGORY_NAME", categoryBox.Text);

            using (SqlDataReader reader = cmmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    categoryId = reader.GetInt32(0);  // Existing category ID
                }
            }
            if (categoryId == -1)
            {
                // get the count and set the id 
                string countQuery = "select count(*) from category";
                SqlCommand cmd2 = new SqlCommand(countQuery, conn);
                int count = (int)cmd2.ExecuteScalar();
                categoryId = count + 1;

                // insert into the category
                string InsertQuery = "INSERT INTO CATEGORY(CATEGORY_NAME,CATEGORY_ID) VALUES(@CATEGORY_NAME,@CATEGORY_ID)";
                SqlCommand cmd3 = new SqlCommand(InsertQuery, conn);
                cmd3.Parameters.AddWithValue("@CATEGORY_NAME", categoryBox.Text);
                cmd3.Parameters.AddWithValue("@CATEGORY_ID", categoryId);
                cmd3.ExecuteNonQuery();
            }
            return categoryId;
        }
        public int GetCopyId()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mariam Omar\\Desktop\\LibraryManagementSystem\\LibraryManagementSystem\\LIBRARY_DB.mdf\";Integrated Security=True";
            //string connString = "Data Source=DESKTOP-09BU7VD\\SQLEXPRESS;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False;";
            SqlConnection conn = new SqlConnection(@connString);
            conn.Open();

            string countQuery = "select count(*) from BOOKCOPY";
            SqlCommand cmd2 = new SqlCommand(countQuery, conn);
            int count = (int)cmd2.ExecuteScalar();
            int CopyId = count + 1;



            return CopyId;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Mariam Omar\\Desktop\\LibraryManagementSystem\\LibraryManagementSystem\\LIBRARY_DB.mdf\";Integrated Security=True";
            //string connString = "Data Source=DESKTOP-09BU7VD\\SQLEXPRESS;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False;";
            SqlConnection connect = new SqlConnection(@connString);

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                MessageBox.Show("not opened!");

            }
            if (connect.State == ConnectionState.Open)
            {
                MessageBox.Show("opened!");
            }


            // When button is clicked, check for all conditions that are made. if all fields are written.
            // Then add the book in the database
            if (title.Text.Length != 0 && isbnValid.Visible == true && publisherValid.Visible == true && categoryBox.Items != null)
            {
                // code to add book to database
                addBookValid.Visible = false;
                int Categoryid = GetCategoryId();

                SqlCommand cmdd = new SqlCommand("insert into BOOK values (@ISBN,@CATEGORY_ID,@PUBLISHING_DATE,@TITLE,@PRICE,@PUBLISHER)", connect);
                cmdd.Parameters.AddWithValue("@ISBN", Convert.ToInt64(isbnText.Text));
                cmdd.Parameters.AddWithValue("@CATEGORY_ID", Categoryid);
                cmdd.Parameters.AddWithValue("@PUBLISHING_DATE", DateTime.Parse(dateTime.Text));
                cmdd.Parameters.AddWithValue("@TITLE", title.Text);
                cmdd.Parameters.AddWithValue("@PRICE", Decimal.Parse(priceSelect.Text));
                cmdd.Parameters.AddWithValue("@PUBLISHER", publish.Text);
                try
                {
                    cmdd.ExecuteNonQuery();
                }


                catch (SqlException ex)
                {
                    // Handle the caught exception
                    Console.WriteLine("SQL Error: " + ex.Message);
                }



                SqlCommand cmddd = new SqlCommand("insert into BOOKCOPY values (@ISBN,@Copy_Id,@NUM_OF_COPIES)", connect);
                cmddd.Parameters.AddWithValue("@ISBN", Convert.ToInt64(isbnText.Text));
                int copy = GetCopyId();
                cmddd.Parameters.AddWithValue("@Copy_Id", copy);
                cmddd.Parameters.AddWithValue("@NUM_OF_COPIES", int.Parse(bookCopyBox.Text));
                cmddd.ExecuteNonQuery();

                SqlCommand cmddddd = new SqlCommand("insert into AUTHOR values (@AUTHOR_Id,@AUTHOR_NAME)", connect);
                cmddddd.Parameters.AddWithValue("@AUTHOR_Id", int.Parse(authorID.Text));
                cmddddd.Parameters.AddWithValue("@AUTHOR_NAME", author.Text);
                cmddddd.ExecuteNonQuery();

                SqlCommand cmdddd = new SqlCommand("insert into WRITTEN_BY values (@ISBN,@AUTHOR_Id)", connect);
                cmdddd.Parameters.AddWithValue("@ISBN", Convert.ToInt64(isbnText.Text));
                cmdddd.Parameters.AddWithValue("@AUTHOR_Id", int.Parse(authorID.Text));
                cmdddd.ExecuteNonQuery();


                MessageBox.Show("LoggedInUsername is: " + (addBookAdmin.LoggedInUsername ?? "null"));
                // Retrieve the ISBN from the isbnText TextBox

                string isbn = isbnText.Text;
                //string check_isbn = "select * from MANAGE where isbn = @isbn";
                //if () { };
                // Define the SQL command to insert USER_ID from ADMIN and ISBN into MANAGE
                string sql = @"INSERT INTO MANAGE (USER_ID, ISBN)
                SELECT USER_ID, @ISBN FROM ADMIN WHERE USERNAME = @username";
                using (SqlCommand command = new SqlCommand(sql, connect))
                {
                    // Ensure the LoggedInUsername property has been set
                    if (string.IsNullOrEmpty(LoggedInUsername))
                    {
                        MessageBox.Show("Username is not set. Please log in again.");
                        return; // Exit the method if no username is set
                    }

                    string currentUser = LoggedInUsername;
                    // Add the ISBN parameter to the command
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    // Ensure the username parameter is added
                    command.Parameters.AddWithValue("@username", currentUser);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show($"Rows affected: {rowsAffected}");
                    }
                    catch (SqlException ex)
                    {
                        // Handle the caught exception
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                }

                connect.Close();
                MessageBox.Show("Successfully Saved");
                // LoggedInUsername = null;

            }
            else
                addBookValid.Visible = true;




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
