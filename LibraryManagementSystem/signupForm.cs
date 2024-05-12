using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class signupForm : Form
    {
        public signupForm()
        {
            InitializeComponent();
            passwordNotCorrect.Visible = false;
            passwordText.UseSystemPasswordChar = true;
            reEnterPasswordText.UseSystemPasswordChar=true;
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

        private void submit_Click(object sender, EventArgs e)
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

        private void passwordNotCorrect_Click(object sender, EventArgs e)
        {
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
    }
}
