using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClinicV2
{
    public partial class ReportDashboard : UserControl
    {
        public ReportDashboard()
        {
            InitializeComponent();
        }

        private void ReportDashboard_Load(object sender, EventArgs e)
        {

        }

        public void getDoctorData()
        {
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";

            string queryServices = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity 
                                    from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name 
                                    where tbl_service.type='Service' and doctor_name='Dr. Diosdado Emmanuel S. Caringal' group by service_name";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
         dataGridReport.Rows.Add(dataReader.GetString(0));
            }

            // code here dataview
            databaseConnection.Close();
        }

        private void dataGridReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

    }
}
