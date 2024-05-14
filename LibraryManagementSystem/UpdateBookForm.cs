using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LibraryManagmentSystem{

public partial class UpdateBookForm : Form
{
    // attributes for Sql connection
    SqlConnection conn = new SqlConnection();

    public UpdateBookForm()
    {
        InitializeComponent();
    }
    private void clear_click(object sender, EventArgs e)
        {
            ISBNVal.Clear();
            Title.Clear();
            publisherval.Clear();
            Authorvar.Clear();
            PDateval.ResetText();
            PriceVal.ResetText();
            categoryval.ResetText();
        }
    private void UpdateBookBtn_Click(object sender, EventArgs e)
    {
        if (ISBNVal.Text=="" || PDateval.Text=="" || Title.Text=="" || PriceVal.Text=="" || publisherval.Text=="" || categoryval.Text=="" || Authorvar.Text ==""){
            MessageBox.Show("Please, fill all fields");
        }
        else {
        string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connString);
        // Open the connection
        conn.Open();

        //get the categoryId 
        int categoryId = GetCategoryId();


        // Insert the data into the database

        string sqlQueryInsert = "update book set ISBN=@ISBN ,CATEGORY_ID=@CATEGORY_ID,PUBLISHING_DATE=@PUBLISHING_DATE, TITLE=@TITLE,PRICE=@PRICE,PUBLISHER=@PUBLISHER where ISBN=@ISBN";
        SqlCommand cmd = new SqlCommand(sqlQueryInsert, conn);
        cmd.Parameters.AddWithValue("@ISBN", Convert.ToInt64(ISBNVal.Text));
        cmd.Parameters.AddWithValue("@PUBLISHING_DATE", DateTime.Parse(PDateval.Text));
        cmd.Parameters.AddWithValue("@TITLE", Title.Text);
        cmd.Parameters.AddWithValue("@PRICE", Decimal.Parse(PriceVal.Text));
        cmd.Parameters.AddWithValue("@PUBLISHER", publisherval.Text);
        cmd.Parameters.AddWithValue("@CATEGORY_ID", categoryId);
        cmd.ExecuteNonQuery();
        // updating the author name into author table

        string AuthorQuery="update AUTHOR set AUTHOR_NAME=@AUTHOR_NAME where AUTHOR_ID=(select ISBN from AUTHOR a join WRITTEN_BY w on a.AUTHOR_ID=w.AUTHOR_ID where ISBN=@ISBN)";
        SqlCommand cmd1 = new SqlCommand(AuthorQuery, conn);
        cmd1.Parameters.AddWithValue("@ISBN", Convert.ToInt64(ISBNVal.Text));
        cmd1.Parameters.AddWithValue("@AUTHOR_NAME", Authorvar.Text);
        cmd1.ExecuteNonQuery();


        // Close the connection
        conn.Close();
        MessageBox.Show("Book Updated Successfully");


    
        }
    }
    public int GetCategoryId(){
        string connString = "Server= localhost; Database= LIBRARY_DB; Integrated Security=True;";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        int categoryId = -1;
        string getQuery ="select CATEGORY_ID from CATEGORY WHERE CATEGORY_NAME=@CATEGORY_NAME";
        SqlCommand cmmd = new SqlCommand(getQuery,conn);
        cmmd.Parameters.AddWithValue("@CATEGORY_NAME",categoryval.Text);

       using (SqlDataReader reader = cmmd.ExecuteReader()){
       if (reader.HasRows)
                {
                    reader.Read();
                    categoryId = reader.GetInt32(0);  // Existing category ID
                }
       }
       if (categoryId==-1) 
       {
        // get the count and set the id 
        string countQuery = "select count(*) from category";
        SqlCommand cmd2 = new SqlCommand(countQuery,conn);
        int count = (int)cmd2.ExecuteScalar();
        categoryId = count + 1;

        // insert into the category
        string InsertQuery ="INSERT INTO CATEGORY(CATEGORY_NAME,CATEGORY_ID) VALUES(@CATEGORY_NAME,@CATEGORY_ID)";
        SqlCommand cmd3 = new SqlCommand(InsertQuery,conn);
        cmd3.Parameters.AddWithValue("@CATEGORY_NAME",categoryval.Text);
        cmd3.Parameters.AddWithValue("@CATEGORY_ID",categoryId);
        cmd3.ExecuteNonQuery();
       }
        return categoryId;
       }
      
    


}
}
