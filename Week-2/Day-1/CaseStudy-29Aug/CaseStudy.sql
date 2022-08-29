create database casestudy
use casestudy
create table doctor(id int, name varchar(30),dept varchar(30),address varchar(30),phone numeric,salary int)
select * from doctor

create table patient(id int, name varchar(30),doctor varchar(30),address varchar(30),phone numeric,bill_amount int)
select * from patient

create table bed(id int, name varchar(30),dept varchar(30),address varchar(30),phone numeric,bedtime int,price int)
select * from bed

create table register_log(logID int identity(100,1),id int,operation nvarchar(20),updateddate Datetime)
select * from register_log


/*Stored Procedure for Doctor Entry*/
create procedure sp_insertDoctor
(@id int,@name nvarchar(30),@dept nvarchar(30),@address nvarchar(30),@phone numeric,@salary int)
as
begin
insert into doctor(id,name,dept,address,phone,salary) values(@id,@name,@dept,@address,@phone,@salary)
end


/*Stored Procedure for Patient Entry*/
create procedure sp_insertPatient
(@id int,@name nvarchar(30),@doctor nvarchar(30),@address nvarchar(30),@phone numeric,@bill_amount int)
as
begin
insert into patient(id,name,doctor,address,phone,bill_amount) values(@id,@name,@doctor,@address,@phone,@bill_amount)
end


/*Stored Procedure for Bed Booking Entry*/
create procedure sp_insertBedBooking
(@id int,@name nvarchar(30),@dept nvarchar(30),@address nvarchar(30),@phone numeric,@bedtime int,@price int)
as
begin
insert into bed(id,name,dept,address,phone,bedtime,price) values(@id,@name,@dept,@address,@phone,@bedtime,(@bedtime*1200))
end



/*Trigger for Doctor Registration*/

create trigger doctorRegisterTrigger 
on doctor
for insert
as
insert into register_log(id,operation,updateddate)
select id,'Docter Entry',GETDATE() from inserted


/*Trigger for Patient Registration*/

create trigger patientRegisterTrigger 
on patient
for insert
as
insert into register_log(id,operation,updateddate)
select id,'Patient Entry',GETDATE() from inserted


/*Trigger for Bed Booking Registration*/

create trigger bedBookingTrigger 
on bed
for insert
as
insert into register_log(id,operation,updateddate)
select id,'Bed booking',GETDATE() from inserted






/*Testing...*/

exec sp_insertDoctor
@id=12,@name='Rajiv',@dept='dentist',@address='delhi',@phone=6789563456,@salary=56000

select * from register_log

exec sp_insertPatient
@id=23,@name='mohan',@doctor='rajiv',@address='patna',@phone=8998628567,@bill_amount=1290

select * from register_log

exec sp_insertBedBooking
@id=1,@name='santosh',@dept='cardio',@address='noida',@phone=8798697127,@bedtime=3,@price=2400

select * from register_log

