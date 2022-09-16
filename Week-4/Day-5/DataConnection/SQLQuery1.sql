create database StudentTracker
use StudentTracker

CREATE TABLE Students
	(
	StudentId int NOT NULL primary key,
	UserName nvarchar(32) NOT NULL,
	FirstName nvarchar(26) NOT NULL,
	LastName nvarchar(26) NOT NULL,
	EMail nvarchar(54) NULL,
	ContactPhone nvarchar(14) NULL,
	DOB datetime NULL,
	CreateDate datetime NOT NULL,
	EditDate datetime NOT NULL
	)

select * from Students

insert into Students values(1,'avneesh.kumar','Avneesh','Kumar','kumar.avneesh@gmail.com','8698346897',CAST((2000-06-29) as datetime),GETDATE(),GETDATE())