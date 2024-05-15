using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LibraryManagmentSystem{

    public partial class UpdateUserForm : Form
    {
            // attributes for Sql connection
        SqlConnection conn = new SqlConnection();

        public UpdateUserForm()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////

                // if the user exist
        public bool IsnewExist(){
            string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string ExistQuery = "select count(*) from [user] where username=@username";
            SqlCommand Existcmd = new SqlCommand(ExistQuery, conn);
            Existcmd.Parameters.AddWithValue("@username", NusernameVal.Text.Trim());
            int rowCount = (int)Existcmd.ExecuteScalar();
            if (rowCount>0){
                return true;
            }
            else
            return false;

        }
        ///////////////////////////////////////////////
        public bool ISUservalid(){
            string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string Validquery = "select count(*) from [user] where username=@username";
            SqlCommand validcmd = new SqlCommand(Validquery, conn);
            validcmd.Parameters.AddWithValue("@username", userNVal.Text.Trim());
            int rowCount2 = (int)validcmd.ExecuteScalar();
            if (rowCount2>0){
                return true;
            }
            else
            return false;


        }

        ////////////////////////////////////////////
        public bool Arefilled(){
            bool AreFilled= string.IsNullOrWhiteSpace(userNVal.Text) ||
                            string.IsNullOrWhiteSpace(passVal.Text)||
                            string.IsNullOrWhiteSpace(NusernameVal.Text) ||
                            string.IsNullOrWhiteSpace(EmailVal.Text);
            return AreFilled;                
        }
        ///////////////////////////////////////////
        //check if he is admin or student

        public bool IsAdmin(){
                bool isAdmin;
                string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string Checkquery = "select is_admin from [user] where USERNAME=@USERNAME";
                SqlCommand Checkcmd = new SqlCommand(Checkquery, conn);
                Checkcmd.Parameters.AddWithValue("@USERNAME", userNVal.Text.Trim());
                using (SqlDataReader reader = Checkcmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    isAdmin = (bool)reader["is_admin"];
                }
                else{
                    isAdmin = false;
                }
            }
            return isAdmin;


        }
        ////////////////////////////////////////////////////
         private byte[] EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                return sha256.ComputeHash(passwordBytes);
            }
        }
        ///////////////////////////////////////////////////////

        private void Clear_Click(object sender, EventArgs e)
        {
            // clear all fields
            userNVal.Clear();
            NusernameVal.Clear();
            passVal.Clear();
            EmailVal.Clear();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (Arefilled())
            {
                MessageBox.Show("Please fill all fields");
            }
            else{
            if (!(ISUservalid()))
                    {
                        MessageBox.Show("This user name is not Exist, please enter the correct user name");
                    }
            if (IsnewExist())
                    {
                        // check if the username is already exist
                        MessageBox.Show("This user name is reserved");
                    
                    }
            else if (ISUservalid() && !(IsnewExist()))
            {
                string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connString);
                // Open the connection
                conn.Open();
                //
                 string Password = passVal.Text.Trim(); //user in login
                 byte[] encryptedPasswordBytes = EncryptPassword(Password); 
                 string encryptedPassword = Convert.ToBase64String(encryptedPasswordBytes);
                 bool Check=IsAdmin();

                //update into user:
                    string sqlUpdateQuery="UPDATE [user] SET EMAIL=@EMAIL, USERNAME=@NUSERNAME,PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME";
                    SqlCommand usercmd = new SqlCommand(sqlUpdateQuery,conn);
                    usercmd.Parameters.AddWithValue("@USERNAME", userNVal.Text.Trim());
                    usercmd.Parameters.AddWithValue("@NUSERNAME",NusernameVal.Text.Trim());
                    usercmd.Parameters.AddWithValue("@PASSWORD",encryptedPassword);
                    usercmd.Parameters.AddWithValue("@EMAIL",EmailVal.Text.Trim());
                    usercmd.ExecuteNonQuery();
                 
               
    

               if (Check){
                    string UpdateAdminQuery="UPDATE Admin SET EMAIL=@EMAIL, USERNAME=@NUSERNAME,PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME";
                    SqlCommand cmd = new SqlCommand(UpdateAdminQuery,conn);
                    cmd.Parameters.AddWithValue("@USERNAME", userNVal.Text.Trim());
                    cmd.Parameters.AddWithValue("@NUSERNAME",NusernameVal.Text.Trim());
                    cmd.Parameters.AddWithValue("@PASSWORD",encryptedPassword);
                    cmd.Parameters.AddWithValue("@EMAIL",EmailVal.Text.Trim());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The details updated succesfully");
            
               }
               else{
                    string UpdateuserQuery="UPDATE STUDENT SET EMAIL=@EMAIL, USERNAME=@NUSERNAME,PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME";
                    SqlCommand cmd = new SqlCommand(UpdateuserQuery,conn);
                    cmd.Parameters.AddWithValue("@USERNAME", userNVal.Text.Trim());
                    cmd.Parameters.AddWithValue("@NUSERNAME",NusernameVal.Text.Trim());
                    cmd.Parameters.AddWithValue("@PASSWORD",encryptedPassword);
                    cmd.Parameters.AddWithValue("@EMAIL",EmailVal.Text.Trim());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The details updated succesfully");
            
               }
               
              
                }
        }
        }
         



    }
}