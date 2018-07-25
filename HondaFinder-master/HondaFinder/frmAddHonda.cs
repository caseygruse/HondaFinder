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
    public partial class frmAddHonda : Form
    {
        public frmAddHonda()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void frmAddHonda_Load(object sender, EventArgs e)
		{
			LoadVehicalModels();
			AddVehicalYears();
			AddVehicalConditions();
		}

		/// <summary>
		/// loads form data for addVehical Form
		/// </summary>
		private void LoadVehicalModels()
		{
			//add models to comboBox
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

		/// <summary>
		/// adds years to comboBox
		/// </summary>
		private void AddVehicalYears()
		{
			for(int i = 1985; i <= 2018; i++)
			{
				cmbYear.Items.Add(i);
			}
		}

		/// <summary>
		/// adds vehicalConditions to comboBox
		/// </summary>
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
