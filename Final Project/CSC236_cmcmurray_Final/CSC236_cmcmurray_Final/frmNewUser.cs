using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_cmcmurray_Final
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void BtnNewUserCancel_Click(object sender, EventArgs e)
        {
            frmSplash newSplash = new frmSplash();
            newSplash.Show();
            this.Hide();
        }
    }
}
