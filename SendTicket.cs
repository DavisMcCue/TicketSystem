using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TicketMessenger
{
    
    public partial class SendTicket : Form
    {
        private string stored_userNameRevieved;
        private string storedSLRevived;
        private DateTime ticketCreationDateTime;
        private int lastTwoDigits = 0;
        private string selectedSubjectOption;
        private string Descriptiontxt;
        public string SecurityLevelRecieved { get; set; }
        SqlConnection connection;
        public SendTicket(string stored_userNameRevievedFromMainMenu, string SLpassed)
        {
            InitializeComponent();
            textOtherBox.Hide();
            labelOther.Hide();
            this.stored_userNameRevieved = stored_userNameRevievedFromMainMenu;
            this.storedSLRevived = SLpassed;
            sendticketUsernameDisplay.Text = stored_userNameRevieved;
            locationlistBox.SelectedIndexChanged += ComboBox_Selected_Index_Change;
            SubjectBoxOptions.SelectedIndexChanged += ComboBox_Selected_Index_Change;
            descriptiontxtbox.TextChanged += ComboBox_Selected_Index_Change;
            bttnTicketSend.Enabled = false;
        }

        private void ComboBox_Selected_Index_Change(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(locationlistBox.Text) && !string.IsNullOrWhiteSpace(SubjectBoxOptions.Text) && !string.IsNullOrWhiteSpace(descriptiontxtbox.Text))
            {
                bttnTicketSend.Enabled = true;
            }
            else
            {
                bttnTicketSend.Enabled = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (buttonBack.Enabled == true)
            {
                var mainMenu = new MainMenu(stored_userNameRevieved, null, storedSLRevived);
                mainMenu.Show();
                CenterToScreen();
                this.Hide();
            }
        }

        private void bttnTicketSend_Click(object sender, EventArgs e)
        {
            int numberRecieved = GenerateTicketNumber();
            if (locationlistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Location");
            }
            else
            {
                string selectedLocationOption = locationlistBox.SelectedItem.ToString();
                selectedSubjectOption = SubjectBoxOptions.SelectedItem.ToString();
                Descriptiontxt = descriptiontxtbox.Text;
                ticketCreationDateTime = DateTime.Now;
                string TResolved = "No";

                TimeSpan timeComponent = ticketCreationDateTime.TimeOfDay;
                DateTime dateComponent = ticketCreationDateTime.Date;
                string formattedTimeConverted = ticketCreationDateTime.ToString("HH:mm");

                connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
                connection.Open();

                if (SubjectBoxOptions.SelectedItem.ToString() == "Other")
                {
                    Descriptiontxt = textOtherBox.Text;
                    selectedSubjectOption = "Other";
                }

                string insertTicketQuery = "INSERT INTO TicketInfo (TicketNumber, TicketName, TicketTime,TicketDate,TicketLocation,TicketDescription,WasTicketResolved) VALUES (@numberRecieved, @selectedSubjectOption, @formattedTimeConverted, @dateComponent, @selectedLocationOption, @Descriptiontxt, @TResolved)";
                using (SqlCommand cmd = new SqlCommand(insertTicketQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@numberRecieved", numberRecieved);
                    cmd.Parameters.AddWithValue("@selectedSubjectOption", selectedSubjectOption);
                    cmd.Parameters.AddWithValue("@formattedTimeConverted", formattedTimeConverted);
                    cmd.Parameters.AddWithValue("@dateComponent", dateComponent);
                    cmd.Parameters.AddWithValue("@selectedLocationOption", selectedLocationOption);
                    cmd.Parameters.AddWithValue("@Descriptiontxt", Descriptiontxt);
                    cmd.Parameters.AddWithValue("@TResolved", TResolved);


                    //using (SqlDataReader reader = cmd.ExecuteReader()) { while (reader.Read()) { string customername = reader["NameofUser"].ToString(); } }

                    int rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0) { MessageBox.Show("Ticket successfully Sent!"); }
                    else { MessageBox.Show("Ticket addition failed."); }
                }
                connection.Close();
                ExcelGen instance = new ExcelGen();
                instance.FindExcel();
            }
        }

        private int GenerateTicketNumber()
        {
            Random rand = new Random();
            int randomFourDigit = rand.Next(10000, 99999);

            lastTwoDigits++;

            if (lastTwoDigits > 99)
            {
                lastTwoDigits = 1;
            }

            string formattedLastTwoDigits = lastTwoDigits.ToString("00");

            string ticketNumber = randomFourDigit.ToString() + formattedLastTwoDigits;

            int ticketNumberConverted = int.Parse(ticketNumber);

            return ticketNumberConverted;
        }

        private void SubjectBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectBoxOptions.SelectedIndex != null)
            {
                if (SubjectBoxOptions.SelectedItem.ToString() == "Other")
                {
                    textOtherBox.Visible = true;
                    labelOther.Visible = true;
                    description.Visible = false;
                    descriptiontxtbox.Visible = false;
                }
                else
                {
                    textOtherBox.Visible = false;
                    labelOther.Visible = false;
                    description.Visible = true;
                    descriptiontxtbox.Visible = true;
                }
            }
        }
    }
}
