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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
        }

        private void Messages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isad157_lhumphriesMessages.messages' table. You can move, or remove it, as needed.
            this.messagesTableAdapter.Fill(this.isad157_lhumphriesMessages.messages);

        }
    }
}
