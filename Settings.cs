using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Diagnostics.Eventing.Reader;
using System.Windows;

namespace TicketMessenger
{
    public partial class Settings : Form
    {
        private string SLpassed;
        private string stored_userNameRevieved;
        
        private bool isSent = false;
        private DateTime targetTime;

        public Settings(string stored_userNameRevieved, string sLpassed)
        {
            InitializeComponent();
            CenterToScreen();
            this.stored_userNameRevieved = stored_userNameRevieved;
            this.SLpassed = sLpassed;

            targetTime = FindTimeUntilNextSuggestedDay();
            CheckDateAndTime.Interval = 1000;
            CheckDateAndTime.Tick += new EventHandler(CheckDateAndTime_Tick);
            CheckDateAndTime.Start();
            isSent = true;
        }
        private void CheckDateAndTime_Tick(object sender, EventArgs e)
        {
            TimeSpan timeremaining = targetTime-DateTime.Now;
                if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday && DateTime.Now.Hour == 9 && DateTime.Now.Minute==35)
                {
                    if (isSent == true)
                    {
                        isSent = false;
                        SendEmailMethod();
                    }
                }
                targetTime = FindTimeUntilNextSuggestedDay();
                Countdownlbl.Text = timeremaining.ToString(@"d\.hh\:mm\:ss");
        }
        private DateTime FindTimeUntilNextSuggestedDay()
        {
            DateTime now = DateTime.Now;
            DateTime daySet = now.AddDays(7-(int)now.DayOfWeek + (int)DayOfWeek.Tuesday);

            daySet = daySet.Date.AddHours(9).AddMinutes(35);
            return daySet;
        }

        private void SendEmailMethod()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string parentFolderName = "TicketMessenger";
            string subfolder1 = "bin";
            string subfolder2 = "debug";
            string excelFileName = "TicketInventory.xlsx";

            string parentFolderPath = Path.Combine(desktopPath, parentFolderName);
            string subFolderPath = Path.Combine(parentFolderPath, subfolder1);
            string subFolderPath2 = Path.Combine(subFolderPath, subfolder2);
            string fullPath = Path.Combine(subFolderPath2, excelFileName);

            //variables
            string senderEmail = "";
            string senderPassword = "";
            string recipientEmail = "";
            string subject = "Weekly Ticket Report Documentation";
            string body = "Hello, Attched is the weekly ticket report.";


            MailMessage mail = new MailMessage(senderEmail, recipientEmail);
            mail.Subject = subject;
            mail.Body = body;

            //add the attachment
            string attachmentPath = fullPath;

            Attachment attachment = new Attachment(attachmentPath);
            mail.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient("");
            client.Port = 0;
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);
            client.EnableSsl = false;

            try
            {
                client.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail didnt Send. " + ex.Message);
            }
            finally
            {
                attachment.Dispose();
            }
            CheckDateAndTime.Stop();    
        }
        private void backbttn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(stored_userNameRevieved, null, SLpassed);
            mainMenu.Show();
            CenterToScreen();
            this.Hide();
        }

        private void Testbttn_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string parentFolderName = "TicketMessenger";
            string subfolder1 = "bin";
            string subfolder2 = "debug";
            string excelFileName = "TicketInventory.xlsx";

            string parentFolderPath = Path.Combine(desktopPath, parentFolderName);
            string subFolderPath = Path.Combine(parentFolderPath, subfolder1);
            string subFolderPath2 = Path.Combine(subFolderPath, subfolder2);
            string fullPath = Path.Combine(subFolderPath2, excelFileName);

            //variables
            string senderEmail = "";
            string senderPassword = "";
            string recipientEmail = "";
            string subject = "Weekly Ticket Report Documentation";
            string body = "Attched is the weekly ticket report.";


            MailMessage mail = new MailMessage(senderEmail, recipientEmail);
            mail.Subject = subject;
            mail.Body = body;

            //add the attachment
            string attachmentPath = fullPath;

            Attachment attachment = new Attachment(attachmentPath);
            mail.Attachments.Add(attachment);

            SmtpClient client = new SmtpClient("");
            client.Port = 0;
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);
            client.EnableSsl = false;

            try
            {
                client.Send(mail);
                MessageBox.Show("Test Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail didnt Send. " + ex.Message);
            }
            finally
            {
                attachment.Dispose();
            }
            CheckDateAndTime.Stop();
        }
    }
}
