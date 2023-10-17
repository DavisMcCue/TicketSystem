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

namespace TicketMessenger
{
    public partial class popup : Form
    {
        SqlConnection connection;
        private string stored_userNameRevieved;
        public popup(string stored_userNameRevievedFromMainMenu)
        {
            InitializeComponent();
            this.stored_userNameRevieved = stored_userNameRevievedFromMainMenu;
            CenterToScreen();
        }

        private void popup_Load(object sender, EventArgs e)
        {

        }

        private void submitBttn_Click(object sender, EventArgs e)
        {
           connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
           connection.Open();

           string foundID = textboxID.Text;

           string selectQuery = "Select * From TicketInfo WHERE TicketID = @foundID";
           using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
           {
               selectCommand.Parameters.AddWithValue("@foundID", foundID);

               SqlDataReader reader = selectCommand.ExecuteReader();
               if (reader.Read())
               {
                   string storedID = reader["TicketID"].ToString();
               }
           }
           connection.Close();

           connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
           connection.Open();
           string isReolved = "Yes";
           string updateQuery = "UPDATE TicketInfo SET WasTicketResolved = @isReolved WHERE TicketID = @foundID";
           string tempSolution = solutionTxtBox.Text;
           using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
           {
               updateCommand.Parameters.AddWithValue("@isReolved", isReolved);
               updateCommand.Parameters.AddWithValue("@foundID", foundID);
               if (tempSolution != null)
               {

                    string insertQuery1 = "UPDATE TicketInfo SET TicketSolution = @tempSolution WHERE TicketID = @foundID";
                    using (SqlCommand cmd1= new SqlCommand(insertQuery1, connection))
                    {
                        cmd1.Parameters.AddWithValue("@tempSolution", tempSolution);
                        cmd1.Parameters.AddWithValue("@foundID", foundID);

                        int rowAffected1 = cmd1.ExecuteNonQuery();
                    }

                    string insertQuery2 = "UPDATE TicketInfo SET ResolvedBy = @stored_userNameRevieved WHERE TicketID = @foundID";
                    using (SqlCommand cmd2 = new SqlCommand(insertQuery2, connection))
                    {
                        cmd2.Parameters.AddWithValue("@stored_userNameRevieved", stored_userNameRevieved);
                        cmd2.Parameters.AddWithValue("@foundID", foundID);

                        int rowAffected2 = cmd2.ExecuteNonQuery();
                    }

                }
               else
               {
                   MessageBox.Show("Please Fill in Solution!");
               }
               int rowAffected = updateCommand.ExecuteNonQuery();
               if (rowAffected > 0) { MessageBox.Show("Ticket Was Resolved by: " + stored_userNameRevieved); }
               else { MessageBox.Show("Ticket has failed to update with username!"); }
               this.Close();
            }
            connection.Close();
        }

        private void popUpBackBttn_Click(object sender, EventArgs e)
        {
            var ticketInventory = new TicketInventory(stored_userNameRevieved);
            ticketInventory.Show();
            CenterToScreen();
            this.Hide();
        }
    }
}
