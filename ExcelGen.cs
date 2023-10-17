using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
using System.Timers;
using OfficeOpenXml;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TicketMessenger
{
    public class ExcelGen
    {
        SqlConnection connection;

        public class FindingTicketInfo
        {

            public string TicketID { get; set; }
            public string TicketNumber { get; set; }
            public string TicketName { get; set; }
            public string TicketTime { get; set; }
            public string TicketDate { get; set; }
            public string TicketLocation { get; set; }
            public string TicketDescription { get; set; }
            public string TResolve { get; set; }
        }
        public void FindExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DP16959\\SQLEXPRESS"].ConnectionString);
            connection.Open();
            string queryString = "SELECT * FROM TicketInfo";

            using (SqlCommand command = new SqlCommand(queryString, connection)) 
            {
                using (SqlDataReader reader = command.ExecuteReader()) 
                {
                    using (var package = new ExcelPackage(new System.IO.FileInfo("TicketInventory.xlsx")))
                    {
                        var worksheet = package.Workbook.Worksheets["Tickets"];

                        if (worksheet != null)
                        {
                           
                            //worksheet.Cells.Clear();
                            int row = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                worksheet.Cells[row, i + 1].Value = reader.GetName(i);
                            }
                            row++;
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    worksheet.Cells[row, i + 1].Value = reader[i];
                                }
                                row++;
                            }
                            try
                            {
                                package.Save();
                                //MessageBox.Show("Excel Saved");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Cant Write to Excel. Please Close Excel!!! " + ex.Message);
                            }
                        }
                    }
                }
            }

        }
    }
}