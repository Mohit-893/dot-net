create database VotingSystem
use VotingSystem

create table VoterList(id int identity,Aadhar nvarchar(16),pancard nvarchar(10),state_ nvarchar(30),isvoted int)
select * from VoterList
drop table VoterList
insert into VoterList values('123412341234','ABCDE1234F','Uttar Pradesh',0)

create table Candidate(id int identity,Name nvarchar(30),votes int)
drop table Candidate
select * from Candidate
insert into Candidate values('A',0)
insert into Candidate values('B',0)
insert into Candidate values('C',0)
insert into Candidate values('D',0)
insert into Candidate values('E',0)


create table VoteDate(id int identity,state_ nvarchar(30),v_date nvarchar(10))
insert into VoteDate values('Uttar Pradesh','09/19/2022')
select * from VoteDate