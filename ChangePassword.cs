using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMessenger
{
    public partial class ChangePassword : Form
    {
        private LogIn logIn;

        public ChangePassword(LogIn logIn)
        {
            InitializeComponent();
            this.logIn = logIn;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text != null && comfirmpasswordTxtBox.Text != null)
            {
                if (passwordTxtBox.Text == comfirmpasswordTxtBox.Text)
                {
                    logIn.changedPasswordFirstTimeUsers = comfirmpasswordTxtBox.Text;
                    LogIn loggingBack = new LogIn();
                    loggingBack.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Doesn't Match.");
                }
            }
            else
            {
                MessageBox.Show("Please change your password.");
            }
        }
    }
}
