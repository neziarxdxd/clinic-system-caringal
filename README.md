# test


restuar@ateneo.edu



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
```
SELECT * FROM `tbl_list_service` WHERE month(date) = 05 and day(date) = 02
```

