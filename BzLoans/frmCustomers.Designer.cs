namespace BzLoans
{
    partial class frmCustomers
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
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.middleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAddress2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderZip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLandline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvCustomers
            // 
            this.lvCustomers.AllowColumnReorder = true;
            this.lvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.middleName,
            this.lastName,
            this.columnHeaderBday,
            this.columnHeaderAddress1,
            this.columnHeaderAddress2,
            this.columnHeaderCity,
            this.columnHeaderState,
            this.columnHeaderCountry,
            this.columnHeaderZip,
            this.columnHeaderEmail,
            this.columnHeaderPhone,
            this.columnHeaderLandline});
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.GridLines = true;
            this.lvCustomers.Location = new System.Drawing.Point(12, 12);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvCustomers.Size = new System.Drawing.Size(789, 417);
            this.lvCustomers.TabIndex = 0;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.SelectedIndexChanged += new System.EventHandler(this.lvCustomers_SelectedIndexChanged);
            this.lvCustomers.DoubleClick += new System.EventHandler(this.lvCustomers_DoubleClick);
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            // 
            // middleName
            // 
            this.middleName.Text = "Middle Name";
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            // 
            // columnHeaderBday
            // 
            this.columnHeaderBday.Text = "Birth Date";
            // 
            // columnHeaderAddress1
            // 
            this.columnHeaderAddress1.Text = "Address 1";
            // 
            // columnHeaderAddress2
            // 
            this.columnHeaderAddress2.Text = "Address 2";
            // 
            // columnHeaderCity
            // 
            this.columnHeaderCity.Text = "City";
            // 
            // columnHeaderState
            // 
            this.columnHeaderState.Text = "State";
            // 
            // columnHeaderCountry
            // 
            this.columnHeaderCountry.Text = "Country";
            // 
            // columnHeaderZip
            // 
            this.columnHeaderZip.Text = "ZIP Code";
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "e-mail";
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Mobile #";
            // 
            // columnHeaderLandline
            // 
            this.columnHeaderLandline.Text = "Land-line";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 441);
            this.Controls.Add(this.lvCustomers);
            this.Name = "frmCustomers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader middleName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader columnHeaderBday;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress1;
        private System.Windows.Forms.ColumnHeader columnHeaderAddress2;
        private System.Windows.Forms.ColumnHeader columnHeaderCity;
        private System.Windows.Forms.ColumnHeader columnHeaderState;
        private System.Windows.Forms.ColumnHeader columnHeaderCountry;
        private System.Windows.Forms.ColumnHeader columnHeaderZip;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderLandline;
    }
}