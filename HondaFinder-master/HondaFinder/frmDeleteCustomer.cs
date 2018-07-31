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
    public partial class frmDeleteCustomer : Form
    {
        public frmDeleteCustomer()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtUserID.Text);
            CustomerDB.Delete(id);
            this.Close();
        }
    }
}
