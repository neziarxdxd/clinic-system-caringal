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
            Console.WriteLine("hehe");
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
