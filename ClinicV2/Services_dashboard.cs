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
    public partial class Services_dashboard : UserControl
    {
        public Services_dashboard()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT * FROM tbl_secretary";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText = "INSERT INTO `tbl_secretary`(`secretary_name`) VALUES (@name)";
            command.Parameters.AddWithValue("@name", textBox1.Text);
            
            command.ExecuteNonQuery();
            databaseConnection.Close();
            refreshTableSecretary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT * FROM tbl_secretary";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText = "DELETE FROM `tbl_secretary` WHERE `secretary_name`=@name";
            command.Parameters.AddWithValue("@name", textBox1.Text);

            command.ExecuteNonQuery();
            databaseConnection.Close();
            refreshTableSecretary();
        }

        private void Services_dashboard_Load(object sender, EventArgs e)
        {
            refreshTable();
            refreshTableSecretary();
        }

        public void refreshTable() {
            dataGridView1.Rows.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT * FROM tbl_service";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
            }
            databaseConnection.Close();
        }

        public void refreshTableSecretary()
        {
            dataGridView2.Rows.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT secretary_name FROM  tbl_secretary";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();

            while (dataReader.Read())
            {
                dataGridView2.Rows.Add(dataReader.GetString(0));
            }
            databaseConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT * FROM tbl_service";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();           
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText = "INSERT INTO `tbl_service`(`doctor_id`, `service_name`, `service_fee`, `type`) VALUES (1,@serviceName,@price,@type)";
            command.Parameters.AddWithValue("@serviceName", txtBoxName.Text);
            command.Parameters.AddWithValue("@price", txtBoxPrice.Value);
            command.Parameters.AddWithValue("@type",comboBoxType.Text );
            command.ExecuteNonQuery();
            databaseConnection.Close();
            refreshTable();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
               textBox1.Text = row.Cells["Full_Name"].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryServices = "SELECT * FROM tbl_service";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryServices, databaseConnection);
            databaseConnection.Open();
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText = "DELETE FROM `tbl_service` WHERE `service_name`=(@serviceName)";
            command.Parameters.AddWithValue("@serviceName", txtBoxName.Text);            
            command.ExecuteNonQuery();
            databaseConnection.Close();
            refreshTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0){
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtBoxName.Text = row.Cells["Service_Name"].Value.ToString();
                txtBoxPrice.Value =Convert.ToDecimal(row.Cells["Price"].Value.ToString());
                comboBoxType.Text = row.Cells["Type"].Value.ToString();
 
            }
        }
    }
}
