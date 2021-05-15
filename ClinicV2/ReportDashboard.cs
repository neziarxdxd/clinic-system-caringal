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
    public partial class reportDashboard : UserControl
    {
        string doctorName;
        public reportDashboard()
        {
            InitializeComponent();
        }

        private void ReportDashboard_Load(object sender, EventArgs e)
        {
           
        }

        public void getDoctorData()
        {
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            dataGridReport.Rows.Clear();
            dataGridReport.Refresh();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();            
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity 
                                    from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name 
                                    where tbl_service.type='Service' and doctor_name=@doctorName group by service_name";
            commandDatabase.Parameters.AddWithValue("@doctorName", doctorName);
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridReport.Rows.Add(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(1));
            }

            // code here dataview
            databaseConnection.Close();
        }

        private void dataGridReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                doctorName = "Dr. Diosdado Emmanuel S. Caringal";
                getDoctorData();              
            }
            else
            {
                doctorName = comboBox1.Text;
                getDoctorData();
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.ToString("MM");
            string day = dateTimePicker1.Value.ToString("DD");
            string year= dateTimePicker1.Value.ToString("YYYY");
            
        }
        

    }
}
