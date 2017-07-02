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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepositoryInterface repo = Program.container.GetInstance<SqlCustomerRepository>();
            frmCustomers frm = new frmCustomers();
            frm.MdiParent = this;
            frm.Show();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frm = new frmCustomers();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
