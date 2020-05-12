using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT562Week18
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)

            // if details are wrong display appropriate message, else open the Homepage form
        {
            if (txtUsername.Text != "ISAD157_LHumphries" || txtPassword.Text != "ISAD157_22222199")
            {
                MessageBox.Show("You have entered incorrect details. Please try again.");
            }

            else
            {
                Homepage homepage = new Homepage();
                homepage.Show();
            }
        }
    }
}
