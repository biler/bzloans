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
    public partial class frmCustomers : Form
    {
        private List<CustomerProfile> customers;
        private SqlCustomerProfileRepository Repository;

        public frmCustomers()
        {
            InitializeComponent();
            Repository = new SqlCustomerProfileRepository();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = Repository.All();
            populateCustomerListView();
        }

        private void populateCustomerListView() {
            ListViewItem lvi = new ListViewItem("Fname");
            lvi.SubItems.Add("middle");
            lvi.SubItems.Add("last");
            lvCustomers.Items.Add(lvi);
            lvCustomers.View = View.Details;
        }
    }
}
