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
using DGVPrinterHelper;
using System.IO;
using System.Drawing.Printing;
namespace ClinicV2
{
    public partial class regular_patient : UserControl
    {
        int i = 0;

        public regular_patient()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void regular_patient_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            string queryDoctor = "SELECT * FROM tbl_doctor";
            string queryService = "SELECT * FROM tbl_service";


            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(queryDoctor, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader dataReader= commandDatabase.ExecuteReader();

            while (dataReader.Read()) {
                comboBox1.Items.Add(dataReader.GetString(1));            
            }
            databaseConnection.Close();

            commandDatabase = new MySqlCommand(queryService, databaseConnection);
            databaseConnection.Open();
            dataReader = commandDatabase.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox2.Items.Add(dataReader.GetString(2));
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Statement",550,850);
            //printDocument1.DefaultPageSettings.Landscape = true;

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printPreviewDialog1.Document = printDocument1;
            }
            
        }

        //to be deleted 

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("fdfd");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

                    }

        private void button5_Click(object sender, EventArgs e)
        {
            
            double totalPrice = 0.00;
            
            
            double price = Double.Parse(txtBoxPrice.Text);
            double quantity = Double.Parse(txtBoxQuantity.Text);
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = quantity;
            dataGridView1.Rows[n].Cells[1].Value = comboBox2.Text;
            dataGridView1.Rows[n].Cells[2].Value = price;
            dataGridView1.Rows[n].Cells[3].Value = price*quantity;

           for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                totalPrice = totalPrice + Convert.ToDouble(dataGridView1.Rows[rows].Cells[3].Value);
            }
           textBoxTotalPrice.Text = "PHP. "+totalPrice.ToString("N");
        
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
            this.dataGridView1.SelectedRows[0].Index !=
            this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int width = 0;
            int height = 0;
            int x = 25;
            int y = 100;
            int rowheight = 0;
            int columnwidth = 100;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);
           
            #region Draw Column 1

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, x, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
            e.Graphics.DrawString(dataGridView1.Columns[0].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(100, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);

            #endregion

            #region Draw column 2

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
            e.Graphics.DrawString(dataGridView1.Columns[1].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(3*x + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 50 + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
            e.Graphics.DrawString(dataGridView1.Columns[2].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(3*x + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);

            width = 0 + dataGridView1.Columns[0].Width;
            height = 100;
            //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
            while (i < dataGridView1.Rows.Count)
            {
                if (height > e.MarginBounds.Height)
                {
                    height = 100;
                    width = 50;
                    e.HasMorePages = true;
                    return;
                }

                // first column
                
                height += dataGridView1.Rows[i].Height;
                
                e.Graphics.DrawRectangle(Pens.Black, x, height+y, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height);
                e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].FormattedValue.ToString(), dataGridView1.Font, Brushes.Black, 
                    new RectangleF(x, height+y, dataGridView1.Columns[0].Width, 
                        dataGridView1.Rows[0].Height), str);
                
                // second column
                e.Graphics.DrawRectangle(Pens.Black, x + dataGridView1.Columns[0].Width, height+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
              e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString(), 
                    dataGridView1.Font, Brushes.Black, 
                    new RectangleF(x + dataGridView1.Columns[0].Width, height+y, 
                        dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);


              // third column
            /**
              e.Graphics.DrawRectangle(Pens.Black, 175 + dataGridView1.Columns[0].Width, height + y, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height);
              e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].FormattedValue.ToString(),
                    dataGridView1.Font, Brushes.Black,
                    new RectangleF(50 + dataGridView1.Columns[0].Width, height + y,
                        dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height), str);
             **/
                width += dataGridView1.Columns[0].Width;
                i++;
            }


            #endregion
        }
    }
}
