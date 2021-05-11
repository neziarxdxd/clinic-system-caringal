using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
