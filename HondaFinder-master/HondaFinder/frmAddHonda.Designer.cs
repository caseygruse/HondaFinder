namespace HondaFinder
{
    partial class frmAddHonda
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
			this.btnExit = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtColor = new System.Windows.Forms.TextBox();
			this.cmbCondition = new System.Windows.Forms.ComboBox();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMileage = new System.Windows.Forms.TextBox();
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(160, 262);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(95, 59);
			this.btnExit.TabIndex = 20;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(29, 262);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(95, 59);
			this.btnSearch.TabIndex = 21;
			this.btnSearch.Text = "Add Honda";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// txtColor
			// 
			this.txtColor.Location = new System.Drawing.Point(89, 206);
			this.txtColor.Name = "txtColor";
			this.txtColor.Size = new System.Drawing.Size(121, 20);
			this.txtColor.TabIndex = 19;
			// 
			// cmbCondition
			// 
			this.cmbCondition.FormattingEnabled = true;
			this.cmbCondition.Location = new System.Drawing.Point(89, 125);
			this.cmbCondition.Name = "cmbCondition";
			this.cmbCondition.Size = new System.Drawing.Size(121, 21);
			this.cmbCondition.TabIndex = 17;
			// 
			// cmbModel
			// 
			this.cmbModel.FormattingEnabled = true;
			this.cmbModel.Location = new System.Drawing.Point(89, 21);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(121, 21);
			this.cmbModel.TabIndex = 14;
			this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Color:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Price:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Condition:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Mileage:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Year:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Model:";
			// 
			// txtMileage
			// 
			this.txtMileage.Location = new System.Drawing.Point(89, 92);
			this.txtMileage.Name = "txtMileage";
			this.txtMileage.Size = new System.Drawing.Size(121, 20);
			this.txtMileage.TabIndex = 22;
			// 
			// cmbYear
			// 
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Location = new System.Drawing.Point(89, 57);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(121, 21);
			this.cmbYear.TabIndex = 23;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(89, 167);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(121, 20);
			this.txtPrice.TabIndex = 24;
			// 
			// frmAddHonda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 350);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.cmbYear);
			this.Controls.Add(this.txtMileage);
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
			this.Name = "frmAddHonda";
			this.Text = "Add a Honda";
			this.Load += new System.EventHandler(this.frmAddHonda_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMileage;
		private System.Windows.Forms.ComboBox cmbYear;
		private System.Windows.Forms.TextBox txtPrice;
	}
}