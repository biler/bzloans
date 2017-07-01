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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtDBHost.Text = Program.settings.db_host;
            txtDBName.Text = Program.settings.db_name;
            txtDBUser.Text = Program.settings.db_username;
            txtDBPassword.Text = Program.settings.db_password;
        }

        private void btnSaveDBSettings_Click(object sender, EventArgs e)
        {
            Program.settings.db_host = txtDBHost.Text;
            Program.settings.db_name = txtDBName.Text;
            Program.settings.db_username = txtDBUser.Text;
            Program.settings.db_password = txtDBPassword.Text;
            Program.settings.Save();

            MessageBox.Show("Database Settings has been saved");
        }
    }
}
