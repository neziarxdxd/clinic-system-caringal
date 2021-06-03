using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicV2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            services_dashboard1.Hide();
            home1.Hide();
            regular_patient1.Show();
            home1.getSummaryReport();
            regular_patient1.BringToFront();
            regular_patient1.refreshListServices();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            services_dashboard1.Hide();
            regular_patient1.Hide();
            reportDashboard1.Hide();
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            services_dashboard1.Hide();
            regular_patient1.Hide();
            reportDashboard1.Hide();
            home1.Show();
            home1.getSummaryReport();
            home1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            services_dashboard1.Hide();
            regular_patient1.Hide();
            reportDashboard1.Hide();
            home1.Show();
            home1.Refresh();
            home1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            home1.Hide();
            regular_patient1.Hide();
            reportDashboard1.Hide();
            services_dashboard1.Show();
            services_dashboard1.Refresh();
            services_dashboard1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            home1.Hide();
            regular_patient1.Hide();          
            services_dashboard1.Hide();
            reportDashboard1.Show();
            reportDashboard1.Refresh();
            reportDashboard1.BringToFront();
        }

        private void reportDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
