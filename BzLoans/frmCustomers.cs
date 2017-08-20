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

            foreach (CustomerProfile customer in customers) {
                ListViewItem lvi = new ListViewItem(customer.FirstName);
                lvi.SubItems.Add(customer.MiddleName);
                lvi.SubItems.Add(customer.LastName);
                lvCustomers.Items.Add(lvi);
            }

            lvCustomers.View = View.Details;
            lvCustomers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void lvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvCustomers_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection items = lvCustomers.SelectedItems;

            //int id = Convert.ToInt32(items[0].Text);

           // MessageBox.Show("value is" + items[0].Text);

            frmEditCustomer frm = new frmEditCustomer();
            frm.MdiParent = ParentForm;
            frm.Show();
        }
    }
}
