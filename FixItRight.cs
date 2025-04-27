using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void txbEmail_Click(object sender, EventArgs e)
        {
            txbEmail.Text = "";
        }
        private void SubmitButton_Click_Click(object sender, EventArgs e)
        {
            string subject = txbSubject.Text;
            if (subject.Length == 0)
            {
                MessageBox.Show("Enter name of item that needs repair.");
                return;
            }

            string name = txbName.Text;
            if (name.Length ==0)
            {
                MessageBox.Show("Please enter your name.");
                return;
            }

            string contactnumber = txbContactNumber.Text;
            //check if input from user is numberic
            if (!contactnumber.All(char.IsDigit))
            {
                MessageBox.Show("Phone number must contain only numbers.");
                return;
            }
            if (contactnumber.Length <10)
            {
                MessageBox.Show("Phone number must be 10 digits long");
                return;
            }
            else if (contactnumber.Length == 0)
            {
                MessageBox.Show("Please enter phone number");
                return;
            }

            string address = txbAddress.Text;
            if (address.Length == 0)
            {
                MessageBox.Show("Please enter address where repair needs to be done.");
                return;
            }

            string description = txbDescription.Text;
            if (description.Length == 0)
            {
                MessageBox.Show("Enter description of the item needing repair or problem.");
                return;
            }

            string hazards = txbHazards.Text;
            if (hazards.Length == 0)
            {
                MessageBox.Show("Enter anything that the maintence person needs to be aware of: \n\nExample: dog.\n\nIf there are no hazards, please enter 0.");
                return;
            }

            string email = txbEmail.Text;
            if (email.Length == 0)
            {
                MessageBox.Show("Enter email address to recieve confirmation of submission.");
                return;
            }
            //If all checks pass
            MessageBox.Show("Thank you! We will get a hold of you as soon as possible.");

        }
        }
    }

