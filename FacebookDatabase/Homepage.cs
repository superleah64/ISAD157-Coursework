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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MyProfile profile = new MyProfile();
            profile.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.Show();
        }
    }
}
