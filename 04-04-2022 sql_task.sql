use AdventureWorks2019
go

--1.

select count(*)
from HumanResources.Department

select sum(Rate) SumOFRate
from HumanResources.EmployeePayHistory

select DATEDIFF(YEAR,StartDate,EndDate) NO_OF_YEARS
from HumanResources.EmployeeDepartmentHistory

select DATEADD(day,5,birthdate) as BirthDate
from HumanResources.Employee

select  CONVERT(int,rate) FloatTOINT
from HumanResources.EmployeePayHistory

select left(name,3) Left4
from HumanResources.Department

select firstName,LEN(FirstName)FirstnameLen
from Person.Person

select firstName, REVERSE(FirstName)ReverseNAME
from Person.Person

--2.

select *
from HumanResources.EmployeePayHistory
go
create function fn_RupeesC(@amount as Nvarchar(50))
returns Nvarchar(50)
as 
begin
return (N'₹'+@amount)
end
go
select BusinessEntityID,dbo.fn_RupeesC(rate) as Dollar 
from HumanResources.EmployeePayHistory
--3

use Trial
go

create view task3
as
select *
from day18t1
go

insert day18t1 values('3','Kavi','M','12345678')

select *
from task3

insert task3 values('4','dhini','M','987654321')

--4.
go
create proc protask4
as 
select *
from day18t2

exec protask4

insert day18t2 values('Rukesh','s','987654321','rukes@','M')

delete day18t2 
where StudentId=2002

update day18t2
set Fname='ivak'
where Fname='kavi'

--5.
go
use AdventureWorks2019

select*
from Production.Product 

select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

--6.
select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]

--7.

select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name