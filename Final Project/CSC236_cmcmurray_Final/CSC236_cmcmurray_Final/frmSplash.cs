using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_cmcmurray_Final
{
    public partial class frmSplash : Form
    {
        private const string FilePath = @"..\CSC236_cmcmurray_Final\Logins.txt";
        public frmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            btnSplashLogin.Focus();
            try
            {
                string username, campaign;

                FileStream infile = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(infile);

                //TODO - implement file reading and writing for logins and campaigns
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void TboxUsername_Enter(object sender, EventArgs e)
        {
            tboxUsername.Text = "";
        }

        private void TboxPassword_Enter(object sender, EventArgs e)
        {
            tboxPassword.Text = "";
        }

        private void BtnSplashNewUser_Click(object sender, EventArgs e)
        {
            frmNewUser newUser = new frmNewUser();
            newUser.Show();
            this.Hide();
        }
    }
}
