create database VotingSystem
use VotingSystem

create table VoterList(id int identity,Aadhar nvarchar(16),pancard nvarchar(10),state_ nvarchar(30),isvoted int)
select * from VoterList
drop table VoterList
insert into VoterList values('123412341234','ABCDE1234F','Uttar Pradesh',0)
insert into VoterList values('234523452345','BCDEF2345G','Delhi',0)
insert into VoterList values('345634563456','CDEFG3456H','Uttar Pradesh',0)
insert into VoterList values('456745674567','DEFGH4567I','Delhi',0)
insert into VoterList values('567856785678','EFGHI5678J','Uttar Pradesh',0)
insert into VoterList values('678967896789','FGHIJ6789K','Delhi',0)
insert into VoterList values('789078907890','GHIJK7890L','Uttar Pradesh',0)

create table Candidate(id int identity,Name nvarchar(30),votes int)
drop table Candidate
select * from Candidate
insert into Candidate values('A',0)
insert into Candidate values('B',0)
insert into Candidate values('C',0)
insert into Candidate values('D',0)
insert into Candidate values('E',0)


create table VoteDate(id int identity,state_ nvarchar(30),v_date nvarchar(10))
drop table VoteDate
insert into VoteDate values('Uttar Pradesh','09/20/2022')
insert into VoteDate values('Delhi','09/21/2022')
select * from VoteDate