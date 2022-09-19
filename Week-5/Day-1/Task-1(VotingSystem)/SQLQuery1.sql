create database VotingSystem
use VotingSystem

create table Candidate(id int identity,Aadhar nvarchar(16),pancard nvarchar(10),state_ nvarchar(30),pincode int,isvoted int,DOB nvarchar(8),UniqueID nvarchar(10))
select * from Candidate
drop table Candidate
insert into Candidate values('','','',,'','')

create table VoterList(id int identity,Name nvarchar(30),votes int)
select * from VoterList
insert into VoterList values('A',0)
insert into VoterList values('B',0)
insert into VoterList values('C',0)
insert into VoterList values('D',0)
insert into VoterList values('E',0)