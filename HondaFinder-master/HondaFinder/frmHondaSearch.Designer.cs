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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbMileage = new System.Windows.Forms.ComboBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mileage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Condition:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
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
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(77, 64);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 2;
            // 
            // cmbMileage
            // 
            this.cmbMileage.FormattingEnabled = true;
            this.cmbMileage.Location = new System.Drawing.Point(77, 99);
            this.cmbMileage.Name = "cmbMileage";
            this.cmbMileage.Size = new System.Drawing.Size(121, 21);
            this.cmbMileage.TabIndex = 3;
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Location = new System.Drawing.Point(77, 135);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(121, 21);
            this.cmbCondition.TabIndex = 4;
            // 
            // cmbPrice
            // 
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(77, 174);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(121, 21);
            this.cmbPrice.TabIndex = 5;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(77, 216);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(121, 20);
            this.txtColor.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(17, 272);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 59);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(148, 272);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 59);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmHondaSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 349);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cmbPrice);
            this.Controls.Add(this.cmbCondition);
            this.Controls.Add(this.cmbMileage);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHondaSearch";
            this.Text = "Search a Honda";
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
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbMileage;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.ComboBox cmbPrice;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}