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
using Microsoft.Reporting.WinForms;

namespace ClinicV2
{
    public partial class regular_patient : UserControl
    {

        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
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


            setInvoiceNumber();
            setCustomerNumber();
            string queryDoctor = "SELECT * FROM tbl_doctor";
            
            string querySecretary = "SELECT secretary_name FROM tbl_secretary";
          
            MySqlDataReader dataReader;
            MySqlCommand commandDatabase;
            
            
            commandDatabase = new MySqlCommand(queryDoctor, databaseConnection);                 
            databaseConnection.Open();
            dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read()) {
                comboBox1.Items.Add(dataReader.GetString(1));            
            }
            databaseConnection.Close();

            

            commandDatabase = new MySqlCommand(querySecretary, databaseConnection);
            databaseConnection.Open();
            dataReader = commandDatabase.ExecuteReader();

            while (dataReader.Read())
            {
                comboBoxPrepared.Items.Add(dataReader.GetString(0));
            }

            databaseConnection.Close();

            refreshListServices();
            refreshCustomer();
           



        }


        public void refreshListServices() {
            comboBox2.Items.Clear();
            medicinecomboBox3.Items.Clear();
            labcomboBox4.Items.Clear();
            MySqlDataReader dataReader;
            MySqlCommand commandDatabase;
            string queryService = "SELECT * FROM tbl_service";
            commandDatabase = new MySqlCommand(queryService, databaseConnection);
            databaseConnection.Open();

            dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader.GetString(4).Equals("Medicine")) {
                    medicinecomboBox3.Items.Add(dataReader.GetString(2));
                }
                else if (dataReader.GetString(4).Equals("Lab"))
                {
                    labcomboBox4.Items.Add(dataReader.GetString(2));
                }
                else
                {
                    Console.WriteLine(dataReader.GetString(2));
                    comboBox2.Items.Add(dataReader.GetString(2));
                }
            }
            databaseConnection.Close();
        }

        public void refreshCustomer()
        {
            searchBarComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBarComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            searchBarComboBox.Items.Clear();
            MySqlDataReader dataReader;
            MySqlCommand commandDatabase;
            string queryService = "SELECT * FROM `tbl_customer";
            commandDatabase = new MySqlCommand(queryService, databaseConnection);
            databaseConnection.Open();

            dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
               
                searchBarComboBox.Items.Add(dataReader.GetString(2));
            }
            databaseConnection.Close();
        }

        public void setInvoiceNumber()
        {
            txtBoxInvoiceID.Clear();
            MySqlCommand commandDatabase;
            MySqlDataReader dataReader;
            string queryMax = "SELECT max(invoice_number)+1 FROM tbl_invoice";
            commandDatabase = new MySqlCommand(queryMax, databaseConnection);
            databaseConnection.Open();
            dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetString(0));
                txtBoxInvoiceID.Text= dataReader.GetString(0);
            }

            databaseConnection.Close();

        }


        public void setCustomerNumber()
        {
            txtBoxCustomerID.Clear();
            MySqlCommand commandDatabase;
            MySqlDataReader dataReader;
            string queryMax = "SELECT max(customer_id)+1 FROM tbl_customer";
            commandDatabase = new MySqlCommand(queryMax, databaseConnection);
            databaseConnection.Open();
            dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetString(0));
                txtBoxCustomerID.Text = dataReader.GetString(0);
            }

            databaseConnection.Close();

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
            /**
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();

            }**/

            printPreviewDialog1.Document = printDocument1;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.DefaultPageSettings.Landscape = false;
                printDocument1.Print();
                //printDocument1.Dispose();
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
            saveCustomerData();
            saveInvoiceTransaction();
            insertDataListOfService();
            printingConfirmation();
            setInvoiceNumber();
            Home c = new Home();
            c.getSummaryReport();
            c.getTotalByLabNow();
            c.getTotalByMedicineNow();
            c.getGrandTotalReport();
            c.getTotalCustomer();
            setCustomerNumber();
            resetAllData();
           
           

        }
        public void resetAllData(){
            txtBoxName.Clear();
            txtBoxAddress.Clear();
            txtBoxModeOfPayment.Clear();            
            dataGridView1.Rows.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            labcomboBox4.SelectedIndex = -1;
            medicinecomboBox3.SelectedIndex = -1;



        }

        private void printingConfirmation()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to print receipt? ", "Success Saved", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                printReceipt();
            }
            
        }


        public void saveInvoiceTransaction() {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText =@"INSERT INTO `tbl_invoice`(`custome_name`, `prepared_by`, `mode_of_payment`) 
                                    VALUES (@customerName, @preparedBy, @modePayment)";
            command.Parameters.AddWithValue("@customerName", txtBoxName.Text);
            command.Parameters.AddWithValue("@preparedBy", comboBoxPrepared.Text);
            command.Parameters.AddWithValue("@modePayment", txtBoxModeOfPayment.Text);
            command.ExecuteNonQuery();
            databaseConnection.Close();
        }

        public void saveCustomerData() {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);           
            databaseConnection.Open();
            MySqlCommand command = databaseConnection.CreateCommand();
            command.CommandText = @"INSERT INTO `tbl_customer`(`customer_name`, `customer_type`, `customer_address`)
                                  VALUES (@customerName, @customerType, @customerAddress)";
            //command.Parameters.AddWithValue("@customerID", txtBoxCustomerID.Text);
            command.Parameters.AddWithValue("@customerName", txtBoxName.Text);
            command.Parameters.AddWithValue("@customerType", comboBoxCustomerType.Text);
            command.Parameters.AddWithValue("@customerAddress", txtBoxAddress.Text);
            command.ExecuteNonQuery();
            databaseConnection.Close();
           
        }

        public void insertDataListOfService() {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();          
            


            
            List<Services> listServices = getListOfServices();
            foreach (var service in listServices){
                MySqlCommand command = databaseConnection.CreateCommand();
                command.CommandText = @"INSERT INTO `tbl_list_service`(`service_name`, `invoice_number`, `doctor_name`, `price`, `quantity`,`total`)
                                        VALUES (@serviceName, @invoiceNumber, @doctor, @price, @quantity, @total)";
                //command.Parameters.AddWithValue("@customerID", txtBoxCustomerID.Text);
                command.Parameters.AddWithValue("@serviceName",service.nameOfService );
                command.Parameters.AddWithValue("@invoiceNumber",txtBoxInvoiceID.Text);
                command.Parameters.AddWithValue("@doctor", comboBox1.Text);
                command.Parameters.AddWithValue("@price", service.price);
                command.Parameters.AddWithValue("@quantity", service.quantity);
                command.Parameters.AddWithValue("@total", service.total);

                command.ExecuteNonQuery();
            }
            databaseConnection.Close();
            

        }

        ReportDataSource rs = new ReportDataSource();
        public void printReceipt() {
            DateTime dateTime = DateTime.Now;
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("parameterCustomer", txtBoxName.Text));
            reportParameters.Add(new ReportParameter("parameterDate", dateTime.ToString("dddd, dd MMMM yyyy")));
            reportParameters.Add(new ReportParameter("parameterAddress", txtBoxAddress.Text));
            reportParameters.Add(new ReportParameter("parameterTotalPrice", textBoxTotalPrice.Text));
            reportParameters.Add(new ReportParameter("parameterPhysician", comboBox1.Text));
            reportParameters.Add(new ReportParameter("parameterPrepared", comboBoxPrepared.Text));
            reportParameters.Add(new ReportParameter("parameterModeOfPayment", txtBoxModeOfPayment.Text));

            List<Services> listServices = getListOfServices();

            rs.Name = "DataSet1";
            rs.Value = listServices;
            Form2 form = new Form2();
            form.reportViewer1.LocalReport.DataSources.Clear();
            form.reportViewer1.LocalReport.DataSources.Add(rs);
            form.reportViewer1.LocalReport.SetParameters(reportParameters);
            form.reportViewer1.LocalReport.ReportEmbeddedResource = "ClinicV2.Report1.rdlc";
            form.ShowDialog();
        }

        private List<Services> getListOfServices()
        {
            List<Services> listServices = new List<Services>();
            listServices.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                Services services = new Services
                {
                    nameOfService = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                    price = double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()),
                    quantity = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()),
                    total = double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())

                };
                listServices.Add(services);
            }
            return listServices;
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
            if (comboBox2.SelectedIndex == -1)
            {

                txtBoxPrice.Value = 0; 
               
                
            }
            else
            {
                MySqlCommand command = databaseConnection.CreateCommand();
                command.CommandText = "SELECT `service_fee` FROM `tbl_service` WHERE `service_name`=@serviceName";
                command.Parameters.AddWithValue("@serviceName", comboBox2.Text);


                databaseConnection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    txtBoxQuantity.Value = 1;
                    txtBoxPrice.Value = Convert.ToDecimal(dataReader.GetString(0));
                }
                databaseConnection.Close();
                
                
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

                    }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonforService();
            
        }

       
        private void buttonforService()
        {
            if (isCustomerComplete())
            {
                MessageBox.Show("You have left a field empty ");
            }
            else
            {
                double totalPrice = 0.00;


                bool isFound = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value) == comboBox2.Text && Convert.ToString(row.Cells[2].Value) == txtBoxPrice.Value.ToString())
                        {
                            row.Cells[0].Value = Convert.ToString(Convert.ToInt16(txtBoxQuantity.Value) + Convert.ToInt16(row.Cells[0].Value));
                            isFound = true;
                        }

                    }
                    if (!isFound)
                    {
                        dataGridView1.Rows.Add(txtBoxQuantity.Value.ToString(), comboBox2.Text, txtBoxPrice.Value.ToString());
                    }

                }
                else
                {
                    dataGridView1.Rows.Add(txtBoxQuantity.Value.ToString(), comboBox2.Text, txtBoxPrice.Value.ToString());
                }
                // compute for total per row
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[3].Value = Convert.ToDouble(row.Cells[0].Value) * Convert.ToInt16(row.Cells[2].Value);
                }
                // compute for total 
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    totalPrice = totalPrice + Convert.ToDouble(dataGridView1.Rows[rows].Cells[3].Value);
                }
                textBoxTotalPrice.Text = "PHP. " + totalPrice.ToString("N");
            }
        }

        private void buttonForLab()
        {
            if ((labtextboxQuantity.Value.ToString().Trim() == string.Empty) || (labtextboxQuantity.Value <= 0) ||
                            (labtextboxFee.Value <= 0))
            {
                MessageBox.Show("You have left a field empty ");
            }
            else
            {
                double totalPrice = 0.00;


                bool isFound = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value) == labcomboBox4.Text && Convert.ToString(row.Cells[2].Value) == labtextboxFee.Value.ToString())
                        {
                            row.Cells[0].Value = Convert.ToString(Convert.ToInt16(labtextboxQuantity.Value) + Convert.ToInt16(row.Cells[0].Value));
                            isFound = true;
                        }

                    }
                    if (!isFound)
                    {
                        dataGridView1.Rows.Add(labtextboxQuantity.Value.ToString(), labcomboBox4.Text, labtextboxFee.Value.ToString());
                    }

                }
                else
                {
                    dataGridView1.Rows.Add(labtextboxQuantity.Value.ToString(), labcomboBox4.Text, labtextboxFee.Value.ToString());
                }
                // compute for total per row
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[3].Value = Convert.ToDouble(row.Cells[0].Value) * Convert.ToInt16(row.Cells[2].Value);
                }
                // compute for total 
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    totalPrice = totalPrice + Convert.ToDouble(dataGridView1.Rows[rows].Cells[3].Value);
                }
                textBoxTotalPrice.Text = "PHP. " + totalPrice.ToString("N");
            }
        }

        private void buttonForMedicine()
        {
            if ((medicinetextboxQuantity.Value.ToString().Trim() == string.Empty) || (medicinetextboxQuantity.Value <= 0) ||
                            (medicinetextboxFee.Value <= 0))
            {
                MessageBox.Show("You have left a field empty ");
            }
            else
            {
                double totalPrice = 0.00;


                bool isFound = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToString(row.Cells[1].Value) == medicinecomboBox3.Text && Convert.ToString(row.Cells[2].Value) == medicinetextboxFee.Value.ToString())
                        {
                            row.Cells[0].Value = Convert.ToString(Convert.ToInt16(medicinetextboxQuantity.Value) + Convert.ToInt16(row.Cells[0].Value));
                            isFound = true;
                        }

                    }
                    if (!isFound)
                    {
                        dataGridView1.Rows.Add(medicinetextboxQuantity.Value.ToString(), medicinecomboBox3.Text, medicinetextboxFee.Value.ToString());
                    }

                }
                else
                {
                    dataGridView1.Rows.Add(medicinetextboxQuantity.Value.ToString(), medicinecomboBox3.Text, medicinetextboxFee.Value.ToString());
                }
                // compute for total per row
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[3].Value = Convert.ToDouble(row.Cells[0].Value) * Convert.ToInt16(row.Cells[2].Value);
                }
                // compute for total 
                for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
                {
                    totalPrice = totalPrice + Convert.ToDouble(dataGridView1.Rows[rows].Cells[3].Value);
                }
                textBoxTotalPrice.Text = "PHP. " + totalPrice.ToString("N");
            }
        }

        private bool isCustomerComplete()
        {
            return (txtBoxAddress.Text.Trim() == string.Empty) || (txtBoxName.Text.Trim() == string.Empty) ||
                            (txtBoxPrice.Value.ToString().Trim() == string.Empty) ||
                            (txtBoxQuantity.Value.ToString().Trim() == string.Empty) || (txtBoxQuantity.Value <= 0) ||
                            (txtBoxPrice.Value <= 0);
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
           

            
        }

        private void printPreviewDialog1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPrepared_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxInvoiceID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchBarComboBox.SelectedIndex == -1)
            {

                


            }
            else
            {
                MySqlCommand command = databaseConnection.CreateCommand();
                command.CommandText = "SELECT * FROM `tbl_customer` WHERE `customer_name`=@nameCustomer";
                command.Parameters.AddWithValue("@nameCustomer", searchBarComboBox.Text);


                databaseConnection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {

                   txtBoxCustomerID.Text = dataReader.GetString(0);
                   txtBoxName.Text = dataReader.GetString(2);
                   txtBoxAddress.Text = dataReader.GetString(4);

                }
                databaseConnection.Close();



            }
        }

        private void medicinecomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (medicinecomboBox3.SelectedIndex == -1)
            {

                medicinetextboxFee.Value = 0;


            }
            else
            {
                MySqlCommand command = databaseConnection.CreateCommand();
                command.CommandText = "SELECT `service_fee` FROM `tbl_service` WHERE `service_name`=@serviceName";
                command.Parameters.AddWithValue("@serviceName", medicinecomboBox3.Text);


                databaseConnection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    medicinetextboxQuantity.Value = 1;
                    medicinetextboxFee.Value = Convert.ToDecimal(dataReader.GetString(0));
                }
                databaseConnection.Close();



            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonForMedicine();
        }

        private void labcomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (labcomboBox4.SelectedIndex == -1)
            {

                labtextboxFee.Value = 0;


            }
            else
            {
                MySqlCommand command = databaseConnection.CreateCommand();
                command.CommandText = "SELECT `service_fee` FROM `tbl_service` WHERE `service_name`=@serviceName";
                command.Parameters.AddWithValue("@serviceName", labcomboBox4.Text);


                databaseConnection.Open();
                MySqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    labtextboxQuantity.Value = 1;
                    labtextboxFee.Value = Convert.ToDecimal(dataReader.GetString(0));
                }
                databaseConnection.Close();



            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonForLab();
        }
    }
}
