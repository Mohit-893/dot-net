create database pizza_store
use pizza_store

create table franchise(id int identity,f_name nvarchar(30),pass nvarchar(30))
select * from franchise


create table employee(id int identity,e_name nvarchar(30),e_dept nvarchar(30),e_sal numeric,e_doj date,f_name nvarchar(30))
select * from employee

insert into employee values('e_name','e_dept',892798,GETDATE(),'delhi')

create table sales(id int identity,c_name nvarchar(30),o_type nvarchar(30),e_name nvarchar(30),price numeric,f_name nvarchar(30),o_date date)
select * from sales

select * from employee where e_doj < DATEADD(month,-1,GETDATE()) and f_name='noida'

select * from sales where o_date = CAST(getdate() as date) and f_name='delhi'

select f_name,sum(price) from sales where o_date = CAST(getdate() as date) group by f_name


