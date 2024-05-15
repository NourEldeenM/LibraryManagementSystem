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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            loginForm loginform = new loginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
