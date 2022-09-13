create database CarApp
use CarApp

create table EmployeeData(id int identity,name nvarchar(30),salary numeric,department nvarchar(30))
select * from EmployeeData
insert into EmployeeData values('Sunil',72,'Paint')
select * from EmployeeData where id=1 and name='Sunil'

create table Sales(id int identity,name nvarchar(30),Carname nvarchar(30),price int,OrderDate date)
select * from Sales

select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate = CAST(GETDATE() as date)
select * from Sales where OrderDate = CAST(GETDATE() as date)
insert into Sales values('Rahul','Sedan',990000,DATEFROMPARTS('2022','09','10'))
select DATEFROMPARTS(year(Orderdate),month(Orderdate),'01') from Sales
select sum(price) as totalsales,count(Carname) as quantity from Sales where OrderDate > DATEFROMPARTS(year(Orderdate),month(Orderdate),'01')


create table EmployeeLogin(id int identity,Emp_ID int,Emp_Name nvarchar(30),LoginTime datetime)
select * from EmployeeLogin

create table EmployeeLogout(id int identity,Emp_ID int,Emp_Name nvarchar(30),LogoutTime datetime)
select * from EmployeeLogout



