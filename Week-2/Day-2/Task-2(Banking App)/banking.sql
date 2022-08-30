create database banking
use banking

create table admin(id int identity(1,1), username nvarchar(30),password nvarchar(30))
select * from admin

insert into admin values('user','root')

create table customer(id int identity(1,1), name nvarchar(30),address nvarchar(30),acc_no nvarchar(30),phone numeric)
select * from customer

create table customer_log(logID int identity(100,1),id int,operation nvarchar(20),updateddate Datetime)
select * from customer_log

create trigger AddCustomerTrigger 
on customer
for insert
as
insert into customer_log(id,operation,updateddate)
select id,'Customer Added',GETDATE() from inserted

create trigger CustomerUpdateTrigger
on customer
after update
as
insert into customer_log(id,operation,updateddate)
select id,'Data Updated',GETDATE() from deleted


create trigger CustomerDeleteTrigger
on customer
after delete
as
insert into customer_log(id,operation,updateddate)
select id,'Data Deleted',GETDATE() from deleted

select * from customer_log