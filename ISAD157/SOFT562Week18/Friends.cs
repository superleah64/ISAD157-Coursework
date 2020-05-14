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
    public partial class Friends : Form
    {
        public Friends()
        {
            InitializeComponent();
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isad157_lhumphriesDataSet.friends' table. You can move, or remove it, as needed.
            this.friendsTableAdapter.Fill(this.isad157_lhumphriesDataSet.friends);

        }
    }
}
