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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            getSummaryReport();
            getTotalByLabNow();
            getTotalByMedicineNow();
            getGrandTotalReport();
            getTotalCustomer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.labelTime.Text = "Time: "+(dateTime.ToString("hh:mm:ss tt"));
            this.labelDate.Text = "Date: " + (dateTime.ToString("dddd, MMMM dd yyyy"));
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void getSummaryReport() {
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            label4.Text = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT SUM(total) FROM tbl_list_service WHERE DATE(`date`) = CURDATE()";




            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                try  { 
                    label4.Text=dataReader.GetString(0);
                    
                }
                catch (Exception e)
                {
                    label4.Text = "0"; 
                }
            }
            label4.Update();
            databaseConnection.Close();
        }


       public void getTotalByLabNow(){
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            labelLabHome.Text = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT sum(total) from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Lab' and DATE(`date`) = CURDATE()";




            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    labelLabHome.Text = dataReader.GetString(0);

                }
                catch (Exception e)
                {
                    labelLabHome.Text = "0";
                }
            }
            labelLabHome.Update();
            databaseConnection.Close();
        }

        public void getTotalByMedicineNow()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            labelMedicineHome.Text = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT sum(total) from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Medicine' and DATE(`date`) = CURDATE()";




            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    labelMedicineHome.Text = dataReader.GetString(0);

                }
                catch (Exception e)
                {
                    labelMedicineHome.Text = "0";
                }
            }
            labelMedicineHome.Update();
            databaseConnection.Close();
        }


        public void getGrandTotalReport()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            labelGrandTotal.Text = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT SUM(total) FROM tbl_list_service";

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    labelGrandTotal.Text = dataReader.GetString(0);

                }
                catch (Exception e)
                {
                    labelGrandTotal.Text = "0";
                }
            }
            labelGrandTotal.Update();
            databaseConnection.Close();
        }

        public void getTotalCustomer()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            labeltotalCustomer.Text = "";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT COUNT(*) FROM `tbl_invoice` where DATE(`date`) = CURDATE()";

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                try
                {
                    labeltotalCustomer.Text = dataReader.GetString(0);

                }
                catch (Exception e)
                {
                    labeltotalCustomer.Text = "0";
                }
            }
            labeltotalCustomer.Update();
            databaseConnection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelLabHome_Click(object sender, EventArgs e)
        {

        }

        private void labelMedicineHome_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
