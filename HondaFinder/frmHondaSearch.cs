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
    public partial class frmHondaSearch : Form
    {
        public frmHondaSearch()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

		private void frmHondaSearch_Load(object sender, EventArgs e)
		{
			LoadVehicalModel();
			AddVehicalYears();
			AddVehicalConditions();
		}


		private void LoadVehicalModel()
		{
			cmbModel.Items.Add("Civic");
			cmbModel.Items.Add("Accord");
			cmbModel.Items.Add("Insight");
			cmbModel.Items.Add("Accord");
			cmbModel.Items.Add("Clarity");
			cmbModel.Items.Add("Fit");
			cmbModel.Items.Add("HR-V");
			cmbModel.Items.Add("CR-V");
			cmbModel.Items.Add("Pilot");
			cmbModel.Items.Add("Odyssey");
			cmbModel.Items.Add("Ridgeline");
			cmbModel.Items.Add("Accord Hybrid");
			cmbModel.Items.Add("Clarity Hybrid");
			cmbModel.Items.Add("Prelude");
		}

		private void AddVehicalYears()
		{
			for (int i = 1985; i <= 2018; i++)
			{
				cmbYear.Items.Add(i);
			}
		}

		private void AddVehicalConditions()
		{
			cmbCondition.Items.Add("Outstanding");
			cmbCondition.Items.Add("Clean");
			cmbCondition.Items.Add("Average");
			cmbCondition.Items.Add("Rough");
			cmbCondition.Items.Add("Damaged");
		}
		/// <summary>
		/// Displays all hondas in the DB and displays them in a listBox for selection
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnViewAllHondas_Click(object sender, EventArgs e)
		{
			List<Vehicle> hondas = VehicalDB.GetAllVehicles();

			foreach(Vehicle v in hondas)
			{
				lbDisplayedHondas.Items.Add(v);
			}
			
		}
		/// <summary>
		/// Add selected honda from the list box to db for the customer with the ID entered into the 
		/// text box labled customerID.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOrderHonda_Click(object sender, EventArgs e)
		{
			CustomerOrder order = new CustomerOrder();

			Vehicle v = (Vehicle)lbDisplayedHondas.SelectedItem;
			if (ValidateCustomerId())
			{
				order.VinNumber = v.VinNumber;
				order.CustomerID = Convert.ToInt16(txtCustomerID.Text);
				order.OrderDate = DateTime.Now;
				OrderDB.AddOrder(order);
				MessageBox.Show("Your order was placed");
			}
		}

		private bool ValidateCustomerId()
		{
			try
			{
				int cusId = Convert.ToInt16(txtCustomerID.Text);
				CustomerDB.GetCustomer(cusId);
				return true;

			}
			catch
			{
				MessageBox.Show("CustomerID is not valid!");
				return false;
			}
			
		}
	}
}
