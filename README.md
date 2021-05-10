# test

QUERIES:
```
SELECT tbl_list_service.service_name, tbl_service.type from tbl_list_service inner join tbl_service on 
tbl_list_service.service_name = tbl_service.service_name where tbl_service.type="Medicine"
```

```
SELECT service_name,SUM(total) totalOfAll FROM `tbl_list_service` WHERE doctor_name="Dr. Diosdado Emmanuel S. Caringal" group by service_name

```

```
THIS CODE IS TO GET SERVICES FROM DOCTOR NAME WITH SUM 

SELECT tbl_list_service.service_name,SUM(total) from tbl_list_service inner join tbl_service on tbl_list_service.service_name = tbl_service.service_name where tbl_service.type="Service" and doctor_name="Dr. Diosdado Emmanuel S. Caringal" group by service_name
```


excess code 


```ll

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
            e.Graphics.DrawString(dataGridView1.Columns[0].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(25, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);

            #endregion

            #region Draw column 2

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
            e.Graphics.DrawString(dataGridView1.Columns[1].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(x + dataGridView1.Columns[0].Width, 100+y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);
            
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(8*x + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width+30, dataGridView1.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 8*x + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height);
            e.Graphics.DrawString(dataGridView1.Columns[2].HeaderText, dataGridView1.Font, Brushes.Black, new RectangleF(8*x + dataGridView1.Columns[0].Width, 100 + y, dataGridView1.Columns[0].Width + columnwidth, dataGridView1.Rows[0].Height), str);
            
            width = 0 + dataGridView1.Columns[0].Width;
            height = 100;
            //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
            while (i < dataGridView1.Rows.Count)
            {
                if (height > e.MarginBounds.Height)
                {
                    height = 100;
                    width = 100;
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


```
