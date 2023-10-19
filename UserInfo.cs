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
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketMessenger
{
    public partial class UserInfo : Form
    {
        private string stored_userNameRevieved;
        public string SecurityLevelRecieved { get; set; }
        SqlConnection connection;
        public UserInfo(string stored_userNameRevievedFromMainMenu)
        {
            InitializeComponent();

            CenterToScreen();
            this.stored_userNameRevieved = stored_userNameRevievedFromMainMenu;



            //checkTheBoxes(nameCheckbox, UserNamecheckBox, passwordcheckBox, securitycheckBox);
        }
        private void getUserInfo(TextBox infoNametxt, TextBox infoUsernametxt, TextBox Security_Lvl_TextBox)
        {
            if (string.IsNullOrEmpty(infoNametxt.Text) && string.IsNullOrEmpty(infoUsernametxt.Text) && string.IsNullOrEmpty(Security_Lvl_TextBox.Text))
            {
                MessageBox.Show("Sorry all three fields weren't filled in. Please Try Again");
            }
            else
            {
                string saveName = infoNametxt.Text;
                string saveUserName = infoUsernametxt.Text;
                string savePassword = "YellowJacket2023!";
                string saveSecurity = Security_Lvl_TextBox.Text;

                dataEncryption(saveName, saveUserName, savePassword, saveSecurity);
            }
        }

        private void dataEncryption(string saveName, string saveUserName, string savePassword, string saveSecurity)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(savePassword); 

            insertDataTODatabase(saveName,saveUserName,hashedPassword,saveSecurity);
        }
        private string resetdataEncryption(string defaultPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(defaultPassword);
            return hashedPassword;
        }

        private void insertDataTODatabase(string saveName, string saveUserName, string hashedPassword, string saveSecurity)
        {

            string tempName = saveName;
            string tempUserName = saveUserName;
            string tempPassword = hashedPassword;
            string tempSecurity = saveSecurity;

            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString);
            connection.Open();

            //string insertQuery = "SELECT * FROM Users";

            string insertQuery = "INSERT INTO Users (NameofUser, UserName, PasswordHash, Security_Level) VALUES (@tempName, @tempUserName, @tempPassword, @tempSecurity)";
            using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@tempName", tempName);
                cmd.Parameters.AddWithValue("@tempUserName", tempUserName);
                cmd.Parameters.AddWithValue("@tempPassword", tempPassword);
                cmd.Parameters.AddWithValue("@tempSecurity", tempSecurity);


              //using (SqlDataReader reader = cmd.ExecuteReader()) { while (reader.Read()) { string customername = reader["NameofUser"].ToString(); } }

              int rowAffected = cmd.ExecuteNonQuery();
              if (rowAffected > 0) { MessageBox.Show("User added successfully!"); }
              else{ MessageBox.Show("User addition failed."); }
            }
            connection.Close();
        }
        private void bttnAddUser_Click(object sender, EventArgs e)
        {
            getUserInfo(InfoNametxt, InfoUsernametxt, Security_Lvl_TextBox );
        }

        private void bttnDeleteUser_Click(object sender, EventArgs e)
        { 
            DeleteUserFromTable(DeleteUserTextBox);
        }

        private void DeleteUserFromTable(TextBox DeleteUserTextBox)
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString);
            connection.Open();

            string deletesaveUserName = DeleteUserTextBox.Text;

            string deleteQuery = "DELETE FROM Users WHERE UserName = @deletesaveUserName";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@deletesaveUserName", deletesaveUserName);
                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0) { MessageBox.Show("Deleted User successfully!"); }
                else { MessageBox.Show("User deletion failed."); }
            }
            connection.Close();
        }

        private void bttnChangeUserInfo_Click(object sender, EventArgs e)
        {
            if (userSearchResetTextbox.Text != null)
            { 
                resetPassword(userSearchResetTextbox);
            }
        }

        private void resetPassword(TextBox UpdateUserTextBox)
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString);
            connection.Open();

            string updateUserPassword = UpdateUserTextBox.Text;

            string defaultPassword = "YellowJacket2023!";

            string newresetdataEncryption = resetdataEncryption(defaultPassword);

            string updateQuery = "UPDATE Users SET PasswordHash = @newresetdataEncryption WHERE UserName = @updateUserPassword";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@newresetdataEncryption", newresetdataEncryption);
                command.Parameters.AddWithValue("@updateUserPassword", updateUserPassword);

                int rowAffected = command.ExecuteNonQuery();
                if (rowAffected > 0) { MessageBox.Show("Updated User successfully!"); }
                else { MessageBox.Show("User Updated failed."); }
            }
            connection.Close();
        }

        private void buttnBacktoMM_Click(object sender, EventArgs e)
        {
            if (buttnBacktoMM.Enabled == true)
            {
                var mainMenu = new MainMenu(stored_userNameRevieved, null, SecurityLevelRecieved);
                mainMenu.Show();
                CenterToScreen();
                this.Hide();
            }
        }
    }
}
