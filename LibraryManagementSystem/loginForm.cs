using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LibraryManagementSystem
{
    public partial class loginForm : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-IJ8RCOH\SQLEXPRESS01;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=true");
        
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\Study\DataBase\LibraryManagementSystem-master\LibraryManagementSystem-master\LibraryManagementSystem\LIBRARY_DB.mdf;Integrated Security = True");
        ConnectionState state = ConnectionState.Open;
        
        public loginForm()
        {
            InitializeComponent();
            passField.UseSystemPasswordChar = true;
            fillAll.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked != true)
                passField.UseSystemPasswordChar = true;
            else
                passField.UseSystemPasswordChar = false;
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_in_login_Click(object sender, EventArgs e)
        {
            signupForm sForm = new signupForm();
            sForm.Show();
            this.Hide();
        }

        private void invalidData_Click(object sender, EventArgs e)
        {

        }
        private byte[] EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                return sha256.ComputeHash(passwordBytes);
            }
        }
        private bool areFieldsFilled = false;
        private void CheckFields()
        {
            areFieldsFilled = !string.IsNullOrWhiteSpace(usernameText.Text) &&
                              !string.IsNullOrWhiteSpace(passField.Text);
        }

        private bool checkIsAdmin(string username)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\LibraryManagementSystem\LibraryManagementSystem\LIBRARY_DB.mdf;Integrated Security=True");
            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                //MessageBox.Show("not opened!");
            }
            string query = $"SELECT is_admin FROM [USER] WHERE USERNAME = '{username}';";
            SqlDataAdapter a = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            a.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                DataRow row = dt.Rows[0];
                if (row["is_admin"].ToString() == "True")
                    return true;
            }
            return false;
            connect.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\LibraryManagementSystem\LibraryManagementSystem\LIBRARY_DB.mdf;Integrated Security=True");

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();
                //MessageBox.Show("not opened!");
            }
            if (connect.State == ConnectionState.Open)
            {
                //MessageBox.Show("opened!");
            }
            CheckFields();
            if (!areFieldsFilled)
            {
                fillAll.Visible = true;
            }
            else if (areFieldsFilled) //hykon feh kol el fuctions
            {
                string query = "SELECT * FROM [USER] WHERE USERNAME = @username";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //password in database    //mypassword in login

                            string password = reader["PASSWORD"].ToString(); //string
                            string mypassword = passField.Text.Trim(); //user in login
                            byte[] encryptedPasswordBytes = EncryptPassword(mypassword); //in login
                            string encryptedPassword = Convert.ToBase64String(encryptedPasswordBytes);
                           // MessageBox.Show(password);
                           // MessageBox.Show(encryptedPassword); //base64
                            if (password.Equals(encryptedPassword))
                            { 
                                // The password is correct, log in the user
                                MessageBox.Show("Login successful!");
                                if (checkIsAdmin(usernameText.Text.Trim()) == true)
                                {
                                    /*menuAdmin ma = new menuAdmin();
                                    ma.Show();
                                    this.Hide();
                                    return;*/
                                    MessageBox.Show("it's admin");
                                    addBookAdmin.LoggedInUsername = usernameText.Text.Trim();
                                    MessageBox.Show("loggedinUsername is " + (addBookAdmin.LoggedInUsername ?? "null"));
                                    addBookAdmin addBookForm = new addBookAdmin();
                                    addBookForm.Show();
                                    this.Hide();
                                }
                                else if (checkIsAdmin(usernameText.Text.Trim()) == false)
                                {
                                    /*menuUser mu = new menuUser();
                                    mu.Show();
                                    this.Hide();
                                    return;*/
                                    MessageBox.Show("it's student");
                                }
                            }
                            else
                            {
                                // The password is incorrect, show an error message
                                MessageBox.Show("Incorrect password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // The username does not exist, show an error message
                            MessageBox.Show("Username not found", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}




















