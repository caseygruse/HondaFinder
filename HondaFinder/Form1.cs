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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchHonda_Click(object sender, EventArgs e)
        {
            frmHondaSearch hondaSearch = new frmHondaSearch();
            hondaSearch.Show();
        }

        private void btnAddHonda_Click(object sender, EventArgs e)
        {
            frmAddHonda addHonda = new frmAddHonda();
            addHonda.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmCreateAccount createAccount = new frmCreateAccount();
            createAccount.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            frmDeleteCustomer deleteCustomer = new frmDeleteCustomer();
            deleteCustomer.Show();
        }

        private void btnFindCustomer_Click(object sender, EventArgs e)
        {
            frmFindCustomer findCustomer = new frmFindCustomer();
            findCustomer.Show();
        }
    }
}
