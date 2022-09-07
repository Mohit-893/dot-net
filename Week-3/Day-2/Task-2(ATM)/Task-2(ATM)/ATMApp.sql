create database atmapp
use atmapp

create table userAccount(id int identity,cardNumber bigint,cardPin int,accountNumber bigint,fullName nvarchar(40),accountBalance numeric,totalLogin int,isLocked int)
select * from userAccount

insert into userAccount values(1234123412341234,4321,12341234,'Mohit',56000,0,0)
insert into userAccount values(5678567856785678,8765,56785678,'Rahul Soni',60000,0,1)
insert into userAccount values(1234567812345678,8721,12345678,'Priya Saini',22000,0,0)

select * from userAccount