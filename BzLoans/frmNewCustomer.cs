using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BzLoans
{
    public partial class frmNewCustomer : Form
    {
        private SqlCustomerProfileRepository Repository;

        public frmNewCustomer()
        {
            InitializeComponent();
            Repository = new SqlCustomerProfileRepository();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomerProfile profile = new CustomerProfile();

            profile.Address1 = txtAddress1.Text;
            profile.Address2 = txtAddress2.Text;
            profile.City = txtCity.Text;
            profile.Birthdate = dtpBirthDate.Value;
            profile.Country = txtCountry.Text;
            profile.Email = txtEmail.Text;
            profile.FirstName = txtFirstName.Text;
            profile.MiddleName = txtMiddleName.Text;
            profile.LastName = txtLastName.Text;
            profile.Title = txtTitle.Text;
            profile.Phone = txtPhone.Text;
            profile.Telephone = txtTelephone.Text;
            profile.State = txtState.Text;
            profile.Zip = txtZipCode.Text;
        
            Repository.Add(profile);
        }

        private void frmNewCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
