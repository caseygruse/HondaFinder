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
	}
}
