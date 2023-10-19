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
    public partial class TicketInventory : Form
    {
        public string SecurityLevelRecieved { get; set; }
        private string stored_userNameRevieved;
        SqlConnection connection;
        public TicketInventory(string stored_userNameRevievedFromMainMenu)
        {
            InitializeComponent();
            CenterToScreen();
            this.stored_userNameRevieved = stored_userNameRevievedFromMainMenu;
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings[""].ConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TicketInfo", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void TicketInventory_Load(object sender, EventArgs e)
        {
            this.ticketInfoTableAdapter.Fill(this.ticketMessengerDataSet1.TicketInfo);

            ExcelGen instance = new ExcelGen();
            instance.FindExcel();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            var popuptime = new popup(stored_userNameRevieved);
            popuptime.Show();

        }

        private void backBttn_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu(stored_userNameRevieved, null, SecurityLevelRecieved);
            mainMenu.Show();
            CenterToScreen();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textboxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
