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
    public partial class frmFindCustomer : Form
    {
        public frmFindCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (!String.IsNullOrEmpty(email))
            {
                List<Customer> customers = CustomerDB.GetAllCustomers();

                foreach(Customer c in customers)
                {
                    if(email == c.EmailAddress)
                    {
                        MessageBox.Show("You're customer id is: " + c.CustomerID);
                        return;
                    }
                }
            }
        }
    }
}
