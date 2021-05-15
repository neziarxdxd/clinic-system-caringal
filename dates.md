SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity from tbl_list_service inner join tbl_service on tbl_list_service.service_name= tbl_service.service_name where tbl_service.type='Service' and doctor_name=@doctorName group by service_name


SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity from tbl_list_service inner join tbl_service on tbl_list_service.service_name= tbl_service.service_name group by service_name

SELECT tbl_list_service.service_name,SUM(total) as total_sale,sum(quantity) as total_quantity from tbl_list_service inner join tbl_service on tbl_list_service.service_name= tbl_service.service_name where MONTH(date)=05 and DAY(date)=05 and YEAR(date)=2021 group by service_name

Antibiotics
36072
12
dentist
18177
3
ksdksk
4445
5
Medical Certificate
6600
11
Professional Fee + Procedure
2500
5