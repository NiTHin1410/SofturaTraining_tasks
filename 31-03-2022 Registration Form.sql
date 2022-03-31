use Trial
go

create table RegForm
(
ApplicationId int identity(1,1),
Fname varchar(20),
Lname varchar(20),
Gender varchar(10) constraint chek check(gender in ('Male','Female','Others')),
Contactno varchar(10),
EmailID varchar(50),
PermanentLocation varchar(100),
CurrentLocation varchar(100),
YearofPassing int,
Qualification varchar(30) constraint qc check(Qualification in ('B.E','B.Tech','M.E','M.Tech')),
LanguageKnown varchar(50),
Nationality varchar(15),
RegisDate date default getdate()
constraint pk_reg primary key(ApplicationID)
)

insert RegForm([Fname],[Lname],[Gender],[Contactno],[EmailID],[PermanentLocation],[CurrentLocation],[YearofPassing],[Qualification],[LanguageKnown],[Nationality])
values ('Nithin','P','Male',6382325571,'nithinpc14@gmail.com','Villupuram','chennai',2022,'B.Tech','Java,html,C#','Indian')
insert RegForm([Fname],[Lname],[Gender],[Contactno],[EmailID],[PermanentLocation],[CurrentLocation],[YearofPassing],[Qualification],[LanguageKnown],[Nationality])
values ('Kavi','B','Male',6383290144,'kavi11balakrishanan@gmail.com','Villupuram','chennai',2022,'B.Tech','java,html,C#','Indian')
insert RegForm([Fname],[Lname],[Gender],[Contactno],[EmailID],[PermanentLocation],[CurrentLocation],[YearofPassing],[Qualification],[LanguageKnown],[Nationality])
values ('Rukesh','K','Male',9655108460,'rukesh1234@gmail.com','vellore','chennai',2022,'B.Tech','python,css,javaScript,html,C#','Indian')

Select *
from RegForm
