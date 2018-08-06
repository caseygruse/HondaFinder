using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HondaFinder
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void frmCreateAccount_Load(object sender, EventArgs e)
		{

		}

		private bool CheckForWhiteSpace(TextBox box)
		{
			if (box.Text.Trim() == "")
			{
				//add error
				return true;
			}
			return false;
		}

		private bool CheckAllTextBoxesForInput()
		{
			foreach(Control c in Controls)
			{
				if(c is TextBox)
				{
					if (CheckForWhiteSpace(c as TextBox))
					{
						return false;
					}
				}
			}
			return true;
		}


		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			if (CheckAllTextBoxesForInput())
			{
				//create customer object using the textboxes
				Customer c = new Customer();
				//add values to properties
				c.FirstName = txtFirstName.Text;
				c.LastName = txtLastName.Text;
				c.PhoneNumber = txtPhoneNumber.Text;
				c.EmailAddress = txtEmail.Text;
				c.StreetAddress = txtStreetAddress.Text;
				c.City = txtCity.Text;
				c.State = txtState.Text;
				//validate for zip which is an int.
				c.ZipCode = Convert.ToInt32(txtZip.Text);
				CustomerDB.AddCustomer(c);
				MessageBox.Show($"Customer Added.\nCustomer ID: {c.CustomerID}");

			}
			else
			{
				MessageBox.Show("not a fields were filled");
			}
		}
	}
}
