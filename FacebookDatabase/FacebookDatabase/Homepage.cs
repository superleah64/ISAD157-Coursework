using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FacebookDatabase
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            Friends friends = new Friends();
            friends.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            messages.Show();
        }
    }
}
