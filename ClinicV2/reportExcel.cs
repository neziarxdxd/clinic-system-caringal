using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient; 
namespace ClinicV2
{
    public partial class reportExcel : UserControl
    {
        public reportExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getSpecificMonth();
           

        }

       

        
        public void getGrandTotal()
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;

            Excel.Worksheet xlWorkSheet;
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            Excel.Workbook xlWorkBook;

            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Name = "Medical All Record";
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            xlWorkSheet.Columns[1].ColumnWidth = 30;
            xlWorkSheet.Columns[2].ColumnWidth = 25;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Medicine'";


            xlWorkSheet.Cells[1, 1] = "Date and Time";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[1, 3] = "Price";
            xlWorkSheet.Cells[1, 4] = "Quantity";
            xlWorkSheet.Cells[1, 5] = "Total";
            
            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            int y = 2;
            while (dataReader.Read())
            {
                xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                y++;
            }

            // code here dataview
            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            databaseConnection.Close();
        }

        public void getSpecificMonth()
        {

            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            for (int month = 11; month >=0; month-- )
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;

                var xlWorkSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                string[] monthString = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            
                xlWorkSheet.Name = monthString[month] + " 2020 ";
               
                // xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
                xlWorkSheet.Columns[1].ColumnWidth = 30;
                xlWorkSheet.Columns[2].ColumnWidth = 25;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                databaseConnection.Open();
                commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Medicine' and month(date) =@monthSpec ORDER by date";
                commandDatabase.Parameters.AddWithValue("@monthSpec", (month+1));

                xlWorkSheet.Cells[1, 1] = "Date and Time";
                xlWorkSheet.Cells[1, 2] = "Name";
                xlWorkSheet.Cells[1, 3] = "Price";
                xlWorkSheet.Cells[1, 4] = "Quantity";
                xlWorkSheet.Cells[1, 5] = "Total";

                MySqlDataReader dataReader = commandDatabase.ExecuteReader();
                int y = 2;
                while (dataReader.Read())
                {
                    xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                    xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                    xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                    xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                    xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                    y++;
                }
                databaseConnection.Close();
             
            }

             String timeString = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            // code here dataview
            xlWorkBook.SaveAs("d:\\Medicine"+timeString+"-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            for (int month = 11; month >= 0; month--)
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;

                var xlWorkSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                string[] monthString = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

                xlWorkSheet.Name = monthString[month] + " 2020 ";

                // xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
                xlWorkSheet.Columns[1].ColumnWidth = 30;
                xlWorkSheet.Columns[2].ColumnWidth = 25;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                databaseConnection.Open();
                commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Lab' and month(date)=@monthSpec ORDER by date";
                commandDatabase.Parameters.AddWithValue("@monthSpec", (month + 1));

                xlWorkSheet.Cells[1, 1] = "Date and Time";
                xlWorkSheet.Cells[1, 2] = "Service Name";
                xlWorkSheet.Cells[1, 3] = "Price";
                xlWorkSheet.Cells[1, 4] = "Quantity";
                xlWorkSheet.Cells[1, 5] = "Total";

                MySqlDataReader dataReader = commandDatabase.ExecuteReader();
                int y = 2;
                while (dataReader.Read())
                {
                    xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                    xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                    xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                    xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                    xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                    y++;
                }
                databaseConnection.Close();

            }
            String timeString = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            // code here dataview
            xlWorkBook.SaveAs("d:\\Laboratory"+timeString+"-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            object misValue = System.Reflection.Missing.Value;

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Excel.Workbook xlWorkBook;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            string[] doctor = { "Dra. Justine Vera", "Dra. Eden ", "Dr. Diosdado" };
            string[] doctorName = { "Dra. Justine Vera Dennys Caringal", "Dra. Eden Caringal", "Dr. Diosdado Emmanuel S. Caringal" };
            for (int i = 0; i<doctor.Length; i++)
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;

                var xlWorkSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
               

                xlWorkSheet.Name = doctor[i] + " 2020";

                // xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
                xlWorkSheet.Columns[1].ColumnWidth = 30;
                xlWorkSheet.Columns[2].ColumnWidth = 25;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                databaseConnection.Open();
                commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='service' and doctor_name=@doctor ORDER by date";
                commandDatabase.Parameters.AddWithValue("@doctor", doctorName[i]);

                xlWorkSheet.Cells[1, 1] = "Date and Time";
                xlWorkSheet.Cells[1, 2] = "Service Name";
                xlWorkSheet.Cells[1, 3] = "Price";
                xlWorkSheet.Cells[1, 4] = "Quantity";
                xlWorkSheet.Cells[1, 5] = "Total";

                MySqlDataReader dataReader = commandDatabase.ExecuteReader();
                int y = 2;
                while (dataReader.Read())
                {
                    xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                    xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                    xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                    xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                    xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                    y++;
                }
                databaseConnection.Close();

            }

            for (int month = 11; month >= 0; month--)
            {
                var xlSheets = xlWorkBook.Sheets as Excel.Sheets;

                var xlWorkSheet = (Excel.Worksheet)xlSheets.Add(xlSheets[1], Type.Missing, Type.Missing, Type.Missing);
                string[] monthString = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };

                xlWorkSheet.Name = monthString[month] + " 2020 ";

                // xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
                xlWorkSheet.Columns[1].ColumnWidth = 30;
                xlWorkSheet.Columns[2].ColumnWidth = 25;

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = databaseConnection.CreateCommand();
                databaseConnection.Open();
                commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='service' and month(date)=@monthSpec ORDER by date";
                commandDatabase.Parameters.AddWithValue("@monthSpec", (month + 1));

                xlWorkSheet.Cells[1, 1] = "Date and Time";
                xlWorkSheet.Cells[1, 2] = "Service Name";
                xlWorkSheet.Cells[1, 3] = "Price";
                xlWorkSheet.Cells[1, 4] = "Quantity";
                xlWorkSheet.Cells[1, 5] = "Total";

                MySqlDataReader dataReader = commandDatabase.ExecuteReader();
                int y = 2;
                while (dataReader.Read())
                {
                    xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                    xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                    xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                    xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                    xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                    y++;
                }
                databaseConnection.Close();

            }



            // code here dataview
             String timeString = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            xlWorkBook.SaveAs("d:\\Services"+timeString+"-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            MessageBox.Show("Excel file created , you can find the file C:");
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
        }

        private void reportExcel_Load(object sender, EventArgs e)
        {

        }



       


       
    }
}
