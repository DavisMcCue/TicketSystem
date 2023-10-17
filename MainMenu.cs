using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketMessenger
{
    public partial class MainMenu : Form
    {
        private string SLpassed;
        private string stored_userNameRevieved;
        public MainMenu(string Username, string Password, string SL)
        {
            InitializeComponent();
            CenterToScreen();
            this.stored_userNameRevieved = Username;
            /*
            EmailSender newinstance = new EmailSender();
            newinstance.ScheduledEmailSender();
            */
            this.SLpassed = SL;

            lblUsername.Text = Username;

            if (SLpassed == "Admin")
            {
                BttnSendIssue.Enabled = true;
                bttnSettings.Enabled = false;
                bttnSettings.Visible = false;
                BttnIssueInventory.Enabled = false;
                BttnIssueInventory.Visible = false;
                bttnUsers.Enabled = false;
                bttnUsers.Visible = false;
                

            }
            else if (SLpassed == "ITAdmin")
            {
                BttnSendIssue.Enabled = true;
                bttnSettings.Enabled = true;
                BttnIssueInventory.Enabled = true;
                bttnUsers.Enabled = true;
            }
        }
        private void BttnSendIssue_Click(object sender, EventArgs e)
        {
            var sendTheTicket = new SendTicket(stored_userNameRevieved,SLpassed);
            sendTheTicket.Show();
            CenterToScreen();
            this.Hide();
        }

        private void bttnUsers_Click(object sender, EventArgs e)
        {
            var Usersinfo = new UserInfo(stored_userNameRevieved);
            Usersinfo.Show();
            CenterToScreen();
            this.Hide();
        }

        private void BttnIssueInventory_Click(object sender, EventArgs e)
        {
            var ticketInventory = new TicketInventory(stored_userNameRevieved);
            ticketInventory.Show();
            CenterToScreen();
            this.Hide();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void bttnSettings_Click(object sender, EventArgs e)
        {
            var callSettings = new Settings(stored_userNameRevieved, SLpassed);
            callSettings.Show();
            CenterToScreen();
            this.Hide();
        }
    }
}
