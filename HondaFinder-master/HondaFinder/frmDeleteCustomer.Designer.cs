namespace HondaFinder
{
    partial class frmDeleteCustomer
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
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(96, 25);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(199, 20);
            this.txtUserID.TabIndex = 1;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(34, 74);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(121, 69);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(172, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 69);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 171);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteCustomer";
            this.Text = "Delete Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnExit;
    }
}