use Trial
go

--Product table

create table Product_table(
ProdID int identity(1,1),
ProdName varchar(20),
Price money,
DateofManufacture date default getdate(),
ExpiryDate date default getdate()
constraint c_Prod primary key(ProdID)
)

--CustomerTable
create table Customer_table(
CustID int identity(1001,1),
Name varchar(20),
Gender varchar(10),
DOB date,
ContactNo varchar(20),
EmailID varchar(20),
City varchar(20),
constraint chk_g check(Gender in ('Male','Female')),
constraint chk_c check(City in ('Chennai','Mumbai')),
constraint c_Cost primary KEy(CustID)
)

--PurChase Table

create table Purchase_table(
BillNo int identity(1,1),
CustID int,
ProdID int,
Quantity int,
TotalAmount int ,
PurchaseDate date default getdate()
constraint c_pur primary KEy(BillNo),
Constraint C_customer foreign key(CustID) references Customer_table(CustID),
Constraint C_proc foreign key(ProdID) references Product_table(ProdID)
)

insert Product_table (ProdName,Price,DateofManufacture,ExpiryDate) values('Kinder Joy',35,getdate(),DATEADD(m,18,getdate()))
delete from Product_table where ProdID=2
select Price*2 from Product_table where ProdID=2;

select sum(TotalAmount)as total
from Purchase_table

insert Customer_table(Name,Gender,DOB,ContactNo,EmailID,City) values('Nithin','Male','2001-05-14','6382325571','nitinpc14@gmail.com','Chennai')
drop table Customer_table
go
select*from Customer_table where Name='Nithin'
go
select sum()
from 

select *from Purchase_table
go
select  ptt.ProdID,CustID,Quantity,ProdName,ptt.TotalAmount
from Product_table pt
join Purchase_table ptt
on pt.ProdID=ptt.ProdID
go


