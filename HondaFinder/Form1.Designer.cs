namespace HondaFinder
{
    partial class frmHome
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
            this.btnAddHonda = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnSearchHonda = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddHonda
            // 
            this.btnAddHonda.Location = new System.Drawing.Point(25, 22);
            this.btnAddHonda.Name = "btnAddHonda";
            this.btnAddHonda.Size = new System.Drawing.Size(131, 77);
            this.btnAddHonda.TabIndex = 0;
            this.btnAddHonda.Text = "Add Honda";
            this.btnAddHonda.UseVisualStyleBackColor = true;
            this.btnAddHonda.Click += new System.EventHandler(this.btnAddHonda_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(215, 22);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(131, 77);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnSearchHonda
            // 
            this.btnSearchHonda.Location = new System.Drawing.Point(395, 22);
            this.btnSearchHonda.Name = "btnSearchHonda";
            this.btnSearchHonda.Size = new System.Drawing.Size(131, 77);
            this.btnSearchHonda.TabIndex = 3;
            this.btnSearchHonda.Text = "Search Hondas";
            this.btnSearchHonda.UseVisualStyleBackColor = true;
            this.btnSearchHonda.Click += new System.EventHandler(this.btnSearchHonda_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(215, 225);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 77);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(215, 122);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(131, 73);
            this.btnDeleteCustomer.TabIndex = 5;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Location = new System.Drawing.Point(25, 122);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(134, 73);
            this.btnFindCustomer.TabIndex = 6;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.UseVisualStyleBackColor = true;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 321);
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnSearchHonda);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddHonda);
            this.Name = "frmHome";
            this.Text = "Honda Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddHonda;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnSearchHonda;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnFindCustomer;
    }
}

