create database fashionStore
use fashionStore

create table category(c_id int identity,c_name nvarchar(30))
select * from category

create table product(p_id int identity,p_name nvarchar(30),p_price numeric,c_id int)
select * from product
insert into category values('Personal care')
insert into category values('Home')
insert into category values('Mobile')