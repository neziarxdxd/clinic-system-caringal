
            string[] monthString = { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec" };
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password='';database=clinic_database;";
            xlWorkSheet.Columns[1].ColumnWidth = 30;
            xlWorkSheet.Columns[2].ColumnWidth = 25;

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = databaseConnection.CreateCommand();
            databaseConnection.Open();
            commandDatabase.CommandText = @"SELECT date,tbl_service.service_name, price,quantity,total from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type='Medicine' and month(date) =@monthSpec";
            commandDatabase.Parameters.AddWithValue("@monthSpec", month);

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
            databaseConnection.Close();
