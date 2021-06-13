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
            
            // TODO: Create SQL queries
            // TODO: SQL queries to Excel
            /**
            xlWorkSheet.Cells[1, 1] = "ID";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[2, 1] = "1";
            xlWorkSheet.Cells[2, 2] = "One";
            xlWorkSheet.Cells[3, 1] = "2";
            xlWorkSheet.Cells[3, 2] = "Two";
            **/






            iterationMonths();

            getGrandTotal();
        }
        Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
        Excel.Workbook xlWorkBook;
        public void getGrandTotal()
        {
            
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }


            
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

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

        public void getSpecificMonth(int month)
        {

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }



            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            string[] monthString = { "Jan", "Feb", "March", "April", "May","June","July","Aug","Sept","Oct","Nov","Dec" };
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(month+1);
            xlWorkSheet.Name =  monthString[month]+ " 2021";
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            xlWorkSheet.Columns[1].ColumnWidth = 30;
            xlWorkSheet.Columns[2].ColumnWidth = 25;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Medicine' and month(date) =@monthSpec";

// TODO: add parameter
            xlWorkSheet.Cells[1, 1] = "Date and Time";
            xlWorkSheet.Cells[1, 2] = "Name";
            xlWorkSheet.Cells[1, 3] = "Price";
            xlWorkSheet.Cells[1, 4] = "Quantity";
            xlWorkSheet.Cells[1, 5] = "Total";

            MySqlDataReader dataReader = commandDatabase.ExecuteReader();
            int y = 2;
            while (dataReader.Read())
            {
                try
                {
                    xlWorkSheet.Cells[y, 1] = dataReader.GetString(0);
                    xlWorkSheet.Cells[y, 2] = dataReader.GetString(1);
                    xlWorkSheet.Cells[y, 3] = dataReader.GetString(2);
                    xlWorkSheet.Cells[y, 4] = dataReader.GetString(3);
                    xlWorkSheet.Cells[y, 5] = dataReader.GetString(4);
                    y++;
                }
                catch(Exception e){
                    Console.WriteLine(0);
                }
            }

            // code here dataview
            xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            databaseConnection.Close();
        }

        public void iterationMonths() {

            for (int i = 0; i < 12; i++) {
                getSpecificMonth(i);
            }
        }


       
    }
}
