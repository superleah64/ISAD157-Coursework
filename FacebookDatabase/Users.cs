﻿using System;
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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'isad157_lhumphriesDataSet.details' table. You can move, or remove it, as needed.
            this.detailsTableAdapter.Fill(this.isad157_lhumphriesDataSet.details);

        }
    }
}
