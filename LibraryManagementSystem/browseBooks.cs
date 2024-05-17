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
   
    public partial class browseBooks : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-IJ8RCOH\\SQLEXPRESS01;Initial Catalog=LIBRARY_DB;Integrated Security=True;Encrypt=False");
        public browseBooks()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void browseBooks_Load(object sender, EventArgs e)
        {

        }

        private void filterButton_CheckedChanged(object sender, EventArgs e)
        {
            if (filterButton.Checked == true) { groupBox1.Visible = true; }
            else { groupBox1.Visible = false; }
        }

        private void bookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (bookname.Text.Length == 0 && filterButton.Checked == false) { return; }

            string searchSql = "";
            if (filterButton.Checked == true)
            {
                bool Lookisbn, Lookyear, Lookauthor;
                if (minISBN.Text.Length != 0 && maxISBN.Text.Length != 0) { Lookisbn = true; }
                else { Lookisbn=false; }

                if (year.Text.Length != 0) { Lookyear = true; }
                else { Lookyear=false; }

                if (author.Text.Length != 0) { Lookauthor = true; }
                else { Lookauthor=false; }

                
                if (bookname.Text.Length == 0)
                {
                    if (Lookisbn && Lookyear && Lookauthor)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text} AND YEAR(PUBLISHING_DATE) = {year.Text} AND PUBLISHER = '{author.Text}';";
                    else if (Lookisbn && Lookyear)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text} AND YEAR(PUBLISHING_DATE) = {year.Text};";
                    else if (Lookisbn)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text};";
                }
                else
                {
                    if (Lookisbn && Lookyear && Lookauthor)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE TITLE like '{bookname.Text}%' AND ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text} AND YEAR(PUBLISHING_DATE) = {year.Text} AND PUBLISHER = {author.Text};";
                    else if (Lookisbn && Lookyear)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE TITLE like '{bookname.Text}%' AND ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text} AND YEAR(PUBLISHING_DATE) = {year.Text};";
                    else if (Lookisbn)
                        searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE TITLE like '{bookname.Text}%' AND ISBN <= {maxISBN.Text} AND ISBN >= {minISBN.Text};";
                }
            }
            else
            {
                // Query the database only with book name
                if (bookname.Text.Length == 0) return;
                searchSql = $"SELECT TITLE, PUBLISHING_DATE, PRICE, ISBN FROM BOOK WHERE TITLE like '{bookname.Text}%';";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(searchSql, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
}
