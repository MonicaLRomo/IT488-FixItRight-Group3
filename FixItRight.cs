using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class FixItRight : Form
    {
        public FixItRight()
        {
            InitializeComponent();
        }

        private void txbContactNumber_TextChanged(object sender, EventArgs e)
        {
            txbContactNumber.Text ="";
        }
        
        private void txbSubject_Click(object sender, EventArgs e)
        {
            txbSubject.Text = "";
        }

        private void txbName_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
        }

        private void txbContactNumber_Click(object sender, EventArgs e)
        {
            txbContactNumber.Text = "";
        }
        private void txbAddress_Click(object sender, EventArgs e)
        {
            txbAddress.Text = "";
        }

        private void txbDescription_Click(object sender, EventArgs e)
        {
            txbDescription.Text = "";
        }

        private void txbHazards_Click(object sender, EventArgs e)
        {
            txbHazards.Text = "";
        }

        
    }
}
