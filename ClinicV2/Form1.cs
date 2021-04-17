using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ClinicV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.MaxLength = 10;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            /**
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            **/
            
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string query = "SELECT * FROM tbl_user WHERE name=@name AND password=@password";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            try
            {
                databaseConnection.Open();
                commandDatabase.Parameters.AddWithValue("@name", textBox1.Text);
                commandDatabase.Parameters.AddWithValue("@password", txtBoxPassword.Text);
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {

                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    databaseConnection.Close();
                }
                else {
                    MessageBox.Show("Not found");
                }


            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
