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

namespace LibraryManagementSystem
{
    public partial class addBookAdmin : Form
    {
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
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            // When button is clicked, check for all conditions that are made. if all fields are written.
            // Then add the book in the database
            if (title.Text.Length != 0 && isbnValid.Visible == true && publisherValid.Visible == true && categoryBox.Items != null)
            {
                // code to add book to database
                addBookValid.Visible = false;
            }
            else
                addBookValid.Visible = true;

        }
    }
}
