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
using Microsoft.Reporting.WinForms;

namespace ClinicV2
{
    public partial class reportDashboard : UserControl
    {
        string doctorName;
        static DateTime thisDay = DateTime.Today;
        string todayDay = thisDay.ToString("MM");
        string todayMonth = thisDay.ToString("dd");
        string todayYear = thisDay.ToString("yyyy");
        string typeString;
        
        public reportDashboard()
        {
            
            InitializeComponent();
        }

        private void ReportDashboard_Load(object sender, EventArgs e)
        {
            getGrandTotal();
        }

        private List<ServiceName> getGenerateService()
        {


            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            List<ServiceName> listServiceName = new List<ServiceName>();
            listServiceName.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity
                                            from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where 
                                            tbl_service.type='Service' group by service_name";
            



            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                ServiceName serviceName = new ServiceName
                {
                    quantityService = dataReader.GetString(2),
                    serviceNameService = dataReader.GetString(0),
                    totalService = dataReader.GetString(1)
                };
                listServiceName.Add(serviceName);
                
            }

            // code here dataview
            databaseConnection.Close();
            return listServiceName;
        }


        private List<DoctorEmm> getGenerteDoctorEmmanuelReport()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            List<DoctorEmm> doctorEmmanuelList = new List<DoctorEmm>();
            doctorEmmanuelList.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity 
                                    from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name 
                                    where tbl_service.type='Service' and doctor_name='Dr. Diosdado Emmanuel S. Caringal' group by service_name";
            
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                DoctorEmm doctorEmm = new DoctorEmm { 
                quantityDoctorEmm  =dataReader.GetString(2),
                serviceNameDoctorEmm = dataReader.GetString(0),
                totalDoctorEmm = dataReader.GetString(1)
                };
                doctorEmmanuelList.Add(doctorEmm);
            }

            // code here dataview
            databaseConnection.Close();

            return doctorEmmanuelList;
        }

        private List<DoctorEden> getGenerteDoctorEdenReport()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            List<DoctorEden> doctorEden = new List<DoctorEden>();
            doctorEden.Clear();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity 
                                    from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name 
                                    where tbl_service.type='Service' and doctor_name='Dra. Eden Caringal' group by service_name";

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                DoctorEden doctorEmm = new DoctorEden
                {
                    quantityDoctorEden= dataReader.GetString(2),
                    serviceNameDoctorEden = dataReader.GetString(0),
                    totalDoctorEden= dataReader.GetString(1)
                };
                doctorEden.Add(doctorEmm);
            }

            // code here dataview
            databaseConnection.Close();

            return doctorEden;
        }

        ReportDataSource doctorEmmDataSource = new ReportDataSource();
        ReportDataSource doctorEddenDataSource = new ReportDataSource();
        ReportDataSource serviceDataSource = new ReportDataSource();
        public void printGenerate() {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            List<DoctorEmm> listDoctorEmm = getGenerteDoctorEmmanuelReport();
            List<DoctorEden> listdoctorEden = getGenerteDoctorEdenReport();
            List<ServiceName> listService = getGenerateService();
            doctorEmmDataSource.Name = "DataSet1";
            doctorEmmDataSource.Value = listDoctorEmm;
            doctorEddenDataSource.Name = "DataSet2";
            doctorEddenDataSource.Value = listdoctorEden;
            serviceDataSource.Name = "DataSet3";
            serviceDataSource.Value = listService;
            FormPrinting form = new FormPrinting();
            form.reportViewerGeneratePrint.LocalReport.DataSources.Clear();
            form.reportViewerGeneratePrint.LocalReport.DataSources.Add(doctorEddenDataSource);
            form.reportViewerGeneratePrint.LocalReport.DataSources.Add(doctorEmmDataSource);
            form.reportViewerGeneratePrint.LocalReport.DataSources.Add(serviceDataSource);  
            form.reportViewerGeneratePrint.LocalReport.ReportEmbeddedResource = "ClinicV2.ReportSales.rdlc";
            form.ShowDialog();
            


        
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

        public void getByDate()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            dataSalesDate.Rows.Clear();
            dataSalesDate.Refresh();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity 
                                           from tbl_list_service 
                                           inner join tbl_service on tbl_list_service.service_name= tbl_service.service_name 
                                           where MONTH(date)=@month and DAY(date)=@day and YEAR(date)=@year 
                                           group by service_name";
            commandDatabase.Parameters.AddWithValue("@day", todayDay);
            commandDatabase.Parameters.AddWithValue("@month", todayMonth);
            commandDatabase.Parameters.AddWithValue("@year", todayYear);

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                dataSalesDate.Rows.Add(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(1));
            }

            // code here dataview
            databaseConnection.Close();
        }

        public void getByService()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
           dataGridType.Rows.Clear();
           dataGridType.Refresh();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity
                                            from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where 
                                            tbl_service.type=@type group by service_name";
            commandDatabase.Parameters.AddWithValue("@type", typeString);
            
            

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridType.Rows.Add(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(1));
            }

            // code here dataview
            databaseConnection.Close();
        }

        public void getGrandTotal()
        {

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity
                                            from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name group by service_name";
            



            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            while (dataReader.Read())
            {
                dataGridView2.Rows.Add(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(1));
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
            todayMonth = dateTimePicker1.Value.ToString("MM");
            todayDay = dateTimePicker1.Value.ToString("dd");
            todayYear = dateTimePicker1.Value.ToString("yyyy");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getByDate();
        }

        private void comboBoxTypeService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeService.SelectedIndex == -1)
            {
                
               
            }
            else
            {
                typeString= comboBoxTypeService.Text;
                getByService();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printGenerate();
        }
        ReportDataSource rs = new ReportDataSource();
        public void printReceipt()
        {
            DateTime dateTime = DateTime.Now;
            /**
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
                     **/
        }
        

    }
}
