namespace HondaFinder
{
    partial class frmHondaSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.cmbCondition = new System.Windows.Forms.ComboBox();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.txtMaxMileage = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.txtMaxPrice = new System.Windows.Forms.TextBox();
			this.lblMinPrice = new System.Windows.Forms.Label();
			this.lblMaxPrice = new System.Windows.Forms.Label();
			this.lbDisplayedHondas = new System.Windows.Forms.ListBox();
			this.btnViewAllHondas = new System.Windows.Forms.Button();
			this.btnOrderHonda = new System.Windows.Forms.Button();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.lblCustomerID = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Model:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Year:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Max Mileage:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Condition:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Price:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Color:";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// cmbModel
			// 
			this.cmbModel.FormattingEnabled = true;
			this.cmbModel.Location = new System.Drawing.Point(77, 31);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(121, 21);
			this.cmbModel.TabIndex = 1;
			// 
			// cmbCondition
			// 
			this.cmbCondition.FormattingEnabled = true;
			this.cmbCondition.Location = new System.Drawing.Point(77, 149);
			this.cmbCondition.Name = "cmbCondition";
			this.cmbCondition.Size = new System.Drawing.Size(121, 21);
			this.cmbCondition.TabIndex = 4;
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(77, 277);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(121, 20);
			this.txtColor.TabIndex = 6;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(15, 355);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(95, 59);
			this.btnSearch.TabIndex = 7;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(143, 355);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(95, 59);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// cmbYear
			// 
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(77, 67);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 8;
			// 
			// txtMaxMileage
			// 
			this.txtMaxMileage.Location = new System.Drawing.Point(98, 104);
			this.txtMaxMileage.Name = "txtMaxMileage";
			this.txtMaxMileage.Size = new System.Drawing.Size(100, 20);
			this.txtMaxMileage.TabIndex = 10;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(98, 193);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 13;
			// 
			// txtMaxPrice
			// 
			this.txtMaxPrice.Location = new System.Drawing.Point(98, 236);
			this.txtMaxPrice.Name = "txtMaxPrice";
			this.txtMaxPrice.Size = new System.Drawing.Size(100, 20);
			this.txtMaxPrice.TabIndex = 14;
			// 
			// lblMinPrice
			// 
			this.lblMinPrice.AutoSize = true;
			this.lblMinPrice.Location = new System.Drawing.Point(65, 193);
			this.lblMinPrice.Name = "lblMinPrice";
			this.lblMinPrice.Size = new System.Drawing.Size(26, 13);
			this.lblMinPrice.TabIndex = 15;
			this.lblMinPrice.Text = "min:";
			// 
			// lblMaxPrice
			// 
			this.lblMaxPrice.AutoSize = true;
			this.lblMaxPrice.Location = new System.Drawing.Point(62, 243);
			this.lblMaxPrice.Name = "lblMaxPrice";
			this.lblMaxPrice.Size = new System.Drawing.Size(29, 13);
			this.lblMaxPrice.TabIndex = 16;
			this.lblMaxPrice.Text = "max:";
			// 
			// lbDisplayedHondas
			// 
			this.lbDisplayedHondas.FormattingEnabled = true;
			this.lbDisplayedHondas.Location = new System.Drawing.Point(274, 31);
			this.lbDisplayedHondas.Name = "lbDisplayedHondas";
			this.lbDisplayedHondas.Size = new System.Drawing.Size(447, 368);
			this.lbDisplayedHondas.TabIndex = 17;
			// 
			// btnViewAllHondas
			// 
			this.btnViewAllHondas.Location = new System.Drawing.Point(15, 445);
			this.btnViewAllHondas.Name = "btnViewAllHondas";
			this.btnViewAllHondas.Size = new System.Drawing.Size(95, 54);
			this.btnViewAllHondas.TabIndex = 18;
			this.btnViewAllHondas.Text = "View All Hondas";
			this.btnViewAllHondas.UseVisualStyleBackColor = true;
			this.btnViewAllHondas.Click += new System.EventHandler(this.btnViewAllHondas_Click);
			// 
			// btnOrderHonda
			// 
			this.btnOrderHonda.Location = new System.Drawing.Point(143, 445);
			this.btnOrderHonda.Name = "btnOrderHonda";
			this.btnOrderHonda.Size = new System.Drawing.Size(95, 54);
			this.btnOrderHonda.TabIndex = 19;
			this.btnOrderHonda.Text = "Order Honda";
			this.btnOrderHonda.UseVisualStyleBackColor = true;
			this.btnOrderHonda.Click += new System.EventHandler(this.btnOrderHonda_Click);
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(274, 445);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerID.TabIndex = 20;
			// 
			// lblCustomerID
			// 
			this.lblCustomerID.AutoSize = true;
			this.lblCustomerID.Location = new System.Drawing.Point(271, 419);
			this.lblCustomerID.Name = "lblCustomerID";
			this.lblCustomerID.Size = new System.Drawing.Size(62, 13);
			this.lblCustomerID.TabIndex = 21;
			this.lblCustomerID.Text = "CustomerID";
			// 
			// frmHondaSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 540);
			this.Controls.Add(this.lblCustomerID);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.btnOrderHonda);
			this.Controls.Add(this.btnViewAllHondas);
			this.Controls.Add(this.lbDisplayedHondas);
			this.Controls.Add(this.lblMaxPrice);
			this.Controls.Add(this.lblMinPrice);
			this.Controls.Add(this.txtMaxPrice);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.txtMaxMileage);
			this.Controls.Add(this.cmbYear);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtColor);
			this.Controls.Add(this.cmbCondition);
			this.Controls.Add(this.cmbModel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmHondaSearch";
			this.Text = "Search a Honda";
			this.Load += new System.EventHandler(this.frmHondaSearch_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.TextBox txtMaxMileage;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox txtMaxPrice;
		private System.Windows.Forms.Label lblMinPrice;
		private System.Windows.Forms.Label lblMaxPrice;
		private System.Windows.Forms.ListBox lbDisplayedHondas;
		private System.Windows.Forms.Button btnViewAllHondas;
		private System.Windows.Forms.Button btnOrderHonda;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Label lblCustomerID;
	}
}