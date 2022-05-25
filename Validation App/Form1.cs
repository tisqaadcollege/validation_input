using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validation_App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel 
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // User Validation Input 
            if(txtUserName.Text == "")
            {
                MessageBox.Show("Please Privide Your Username");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please Privide Your Password");
            }
            else
            {
                // Application Dashboard 

                frmDashboard dashboard = new frmDashboard();

                dashboard.Show();
                Hide();
            }
        }
    }
}
