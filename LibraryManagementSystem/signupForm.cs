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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace LibraryManagementSystem
{
    public partial class signupForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\LibraryManagementSystem\LibraryManagementSystem\LIBRARY_DB.mdf;Integrated Security=True");
        //SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mariam Omar\Desktop\Study\DataBase\LibraryManagementSystem-master\LibraryManagementSystem-master\LibraryManagementSystem\LIBR_DB.mdf;Integrated Security = True");
        ConnectionState state = ConnectionState.Open;
        public signupForm()
        {
            InitializeComponent();
            passwordNotCorrect.Visible = false;
            passwordText.UseSystemPasswordChar = true;
            reEnterPasswordText.UseSystemPasswordChar=true;
            alert.Visible = false;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] encryptedBytes = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(encryptedBytes);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            CheckFields();
            if (areFieldsFilled == false)
            {
                alert.Visible = true;
            }
            else
            {
                alert.Visible = false;
            
            checkType();

            if (connect.State != ConnectionState.Open)
            {
                connect.Open();

            }
            if (connect.State == ConnectionState.Open)
            {
                //MessageBox.Show("opened!");

                String checkUsername = "SELECT * FROM [USER] WHERE USERNAME = '"
                            + usernameText.Text.Trim() + "'";

                using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        MessageBox.Show(usernameText.Text + " is already exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else   //valid user name
                    {

                        string encryptedPassword = EncryptPassword(passwordText.Text.Trim());
                        string insertData = "INSERT INTO [USER] (Email,is_admin, USERNAME, PASSWORD) VALUES (@email, @is_admin, @username, @password)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@email", emailText.Text.Trim());
                            cmd.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", encryptedPassword);
                            cmd.Parameters.AddWithValue("@is_admin", isAdmin);
                            cmd.ExecuteNonQuery();

                        }
                        //int userId = (int)cmd.ExecuteScalar();      //hena hykon fe el id
                        if (isAdmin)
                        {
                            string selectUserId = "SELECT user_id FROM [USER] WHERE Email = @email AND USERNAME = @username AND PASSWORD = @password AND is_admin = 1";
                            using (SqlCommand cmd = new SqlCommand(selectUserId, connect))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", encryptedPassword);
                                cmd.Parameters.AddWithValue("@is_admin", isAdmin);
                                int userId = (int)cmd.ExecuteScalar();
                                // Now you can use the userId variable
                                // MessageBox.Show(userId.ToString());


                                string insertAdmin = "INSERT INTO [ADMIN] (USER_ID,is_admin,EMAIL, USERNAME, PASSWORD) VALUES (@userid,@is_admin, @email, @username, @password)";
                                using (SqlCommand cmd1 = new SqlCommand(insertAdmin, connect))
                                {
                                    cmd1.CommandType = CommandType.Text;
                                    cmd1.Parameters.AddWithValue("@userid", userId);
                                    cmd1.Parameters.AddWithValue("@is_admin", isAdmin);
                                    cmd1.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@password", encryptedPassword);
                                    cmd1.ExecuteNonQuery();
                                }
                            }

                        }
                        else  //if it's student
                        {
                            string selectUserId = "SELECT user_id FROM [USER] WHERE Email = @email AND USERNAME = @username AND PASSWORD = @password AND is_admin = 0";
                            using (SqlCommand cmd = new SqlCommand(selectUserId, connect))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                cmd.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                cmd.Parameters.AddWithValue("@password", encryptedPassword);
                                cmd.Parameters.AddWithValue("@is_admin", isAdmin);
                                int userId = (int)cmd.ExecuteScalar();
                                // Now you can use the userId variable
                                //MessageBox.Show(userId.ToString());


                                string insertAdmin = "INSERT INTO [STUDENT] (USER_ID,is_admin,EMAIL, USERNAME, PASSWORD) VALUES (@userid,@is_admin, @email, @username, @password)";
                                using (SqlCommand cmd1 = new SqlCommand(insertAdmin, connect))
                                {
                                    cmd1.CommandType = CommandType.Text;
                                    cmd1.Parameters.AddWithValue("@userid", userId);
                                    cmd1.Parameters.AddWithValue("@is_admin", isAdmin);
                                    cmd1.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                    cmd1.Parameters.AddWithValue("@password", encryptedPassword);
                                    cmd1.ExecuteNonQuery();
                                }
                            }


                        }


                        MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Switch to the login form
                        loginForm lForm = new loginForm();
                        lForm.Show();
                        this.Hide();

                    }
                }

            }
        }
            
        }
        private void passwordNotCorrect_Click(object sender , EventArgs e)
        {

        }

        private void checkBoxPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass2.Checked == false) {
                passwordText.UseSystemPasswordChar = true; 
                reEnterPasswordText.UseSystemPasswordChar = true;
            } 
            else 
            {
                passwordText.UseSystemPasswordChar = false;
                reEnterPasswordText.UseSystemPasswordChar = false;
            }
        }

        private void reEnterPasswordText_TextChanged(object sender, EventArgs e)
        {
            if (passwordText.Text != reEnterPasswordText.Text)
            {
                passwordNotCorrect.Visible = true;
            }
            else
            {
                passwordNotCorrect.Visible = false;
            }
        }

        private void Username_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm lForm = new loginForm();
            lForm.Show();
            this.Hide();
        }

        private void alert_Click(object sender, EventArgs e)
        {

        }

        private bool areFieldsFilled = false;
        private void CheckFields()
        {
            areFieldsFilled = !string.IsNullOrWhiteSpace(usernameText.Text) &&
                              !string.IsNullOrWhiteSpace(emailText.Text) &&
                              !string.IsNullOrWhiteSpace(passwordText.Text) &&
                              !string.IsNullOrWhiteSpace(reEnterPasswordText.Text);
        }

        bool isAdmin = false;
        private void checkType()
        {
            if (checkBoxAdmin.Checked)
            {
                isAdmin = true;
            }
        }


    } // end of the signup functionalities
}









// function to determine if it's student or admin                    (done)
// function to set the data in USER table                             (done)
// function to put the data in the correct table "admin or student"     (done)
// function to check username is not repeated                           (done)
// function to check if all the fields are filled or not              (done)
// encryption the password                                             (done)












//=================================================================================================================================


/*
  int userId = (int)cmd.ExecuteScalar();      //hena hykon fe el id
                            if (isAdmin)
                            {
                                string insertDataAdmin = "INSERT INTO [ADMIN] (USER_ID, is_admin, EMAIL,USERNAME , PASSWORD) VALUES (@userId, @is_admin, @email,@username, @password)";
                                using (SqlCommand cmdAdmin = new SqlCommand(insertDataAdmin, connect))
                                {
                                    cmdAdmin.CommandType = CommandType.Text;
                                    cmdAdmin.Parameters.AddWithValue("@userId", userId);
                                    cmdAdmin.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                    cmdAdmin.Parameters.AddWithValue("@password", passwordText.Text.Trim());
                                    cmdAdmin.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                    cmdAdmin.Parameters.AddWithValue("@is_admin", isAdmin);


                                    cmdAdmin.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string insertDataStudent = "INSERT INTO [STUDENT] (USER_ID, is_admin, EMAIL,USERNAME , PASSWORD) VALUES (@userId, @is_admin, @email,@username, @password)";
                                using (SqlCommand cmdStudent = new SqlCommand(insertDataStudent, connect))
                                {
                                    cmdStudent.CommandType = CommandType.Text;
                                    cmdStudent.Parameters.AddWithValue("@userId", userId);
                                    cmdStudent.Parameters.AddWithValue("@email", emailText.Text.Trim());
                                    cmdStudent.Parameters.AddWithValue("@username", usernameText.Text.Trim());
                                    cmdStudent.Parameters.AddWithValue("@password", passwordText.Text.Trim());
                                    cmdStudent.Parameters.AddWithValue("@is_admin", isAdmin);

                                    cmdStudent.ExecuteNonQuery();
                                }
                            }
 
 */