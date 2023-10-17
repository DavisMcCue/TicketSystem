using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Common.CommandTrees.ExpressionBuilder;

namespace TicketMessenger
{
    public partial class LogIn : Form
    {
        SqlConnection connection;
        public string changedPasswordFirstTimeUsers { get; set; }

        public LogIn()
        {
            InitializeComponent();
            CenterToScreen();
            
        }
        private void BttnLogIn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
            connection.Open();

            string checkUsername = txtUserName.Text;
            string checkPassword = txtPassword.Text;

            string checkIfUserExists = "SELECT COUNT(*) FROM Users Where Username = @checkUsername";
            using (SqlCommand UserExistcommand = new SqlCommand(checkIfUserExists, connection))
            {
                UserExistcommand.Parameters.AddWithValue("@checkUsername",checkUsername);
                int count = (int)UserExistcommand.ExecuteScalar();
                if (count > 0)
                {
                    if (checkPassword == "YellowJacket2023!")
                    {
                        MessageBox.Show("Must Change Password to Continue!");
                        ChangePassword changePasswordnewUser = new ChangePassword(this);
                        changePasswordnewUser.ShowDialog();

                        string newresetdataEncryption = resetdataEncryption(changedPasswordFirstTimeUsers);

                        string updateQuery = "UPDATE Users SET PasswordHash = @newresetdataEncryption WHERE UserName = @checkUsername";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@newresetdataEncryption", newresetdataEncryption);
                            command.Parameters.AddWithValue("@checkUsername", checkUsername);

                            int rowAffected = command.ExecuteNonQuery();
                            if (rowAffected > 0) { MessageBox.Show("Updated User password successfully!"); }
                            else { MessageBox.Show("User Updated password failed."); }
                        }
                        connection.Close();
                        LogIn logingIn = new LogIn();
                        logingIn.Show();
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                    else
                    {

                        connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
                        connection.Open();

                        string queryString = "SELECT UserName, PasswordHash, Security_Level FROM Users WHERE UserName = @checkUsername";
                        using (SqlCommand cmd = new SqlCommand(queryString, connection))
                        {
                            cmd.Parameters.AddWithValue("@checkUsername", checkUsername);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                string storedUsername = reader["UserName"].ToString();
                                string storedPasswordHash = reader["PasswordHash"].ToString();
                                string storedSecurityLevel = reader["Security_Level"].ToString();
                                bool passwordMatches = BCrypt.Net.BCrypt.Verify(checkPassword, storedPasswordHash);

                                if (passwordMatches && storedUsername == checkUsername)
                                {
                                    //MessageBox.Show("Login Successful!");
                                    new MainMenu(txtUserName.Text, txtPassword.Text, storedSecurityLevel).Show();
                                    SendTicket sendticket = new SendTicket(checkUsername, storedSecurityLevel);
                                    sendticket.SecurityLevelRecieved = storedSecurityLevel;
                                    //sendticket.UserNameRevieved = checkUsername;
                                    this.Hide();
                                }
                                else
                                {
                                    txtUserName.Clear();
                                    txtPassword.Clear();
                                    txtUserName.Focus();
                                    MessageBox.Show("Invalid username or password!");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist. Please Try Again");
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
        }

        private string resetdataEncryption(string defaultPassword)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(defaultPassword);
            return hashedPassword;
 
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Clerk of Courts IT");
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
