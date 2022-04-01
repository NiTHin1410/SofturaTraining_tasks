use AdventureWorks2019
go

--1.
select FirstName,LastName
from Person.Person
where Title is not null

--2.

select FirstName,LastName
from Person.Person
where FirstName like  '%a'and
lastname like '%a'

--3.

select cc.CurrencyCode,Name
from Sales.Currency,Sales.CountryRegionCurrency cc

 --4.
 go
 create view HRDept1
 as
 select  DepartmentId,Name,GroupName,ModifiedDate
 from HumanResources.Department
 go

 select * from HRDept1

 --5
 create table Task5
 (
 SNO int identity(1,1) ,
 FName varchar(20),
 LNAme varchar(20),
 Gender char(1) constraint gchk check (gender in('M','F')),
 InsertDate date default getdate()
 constraint pk_task5 primary Key(SNO)
 )

 insert Task5(FName,LNAme,Gender)
 values('Jackey','P','M')
 
 select*from task5
 
 --6

 select  emph.businessEntityId,AddressTypeID
 from Person.BusinessEntityAddress Bea
 inner join HumanResources.EmployeeDepartmentHistory emph
 on emph.BusinessEntityID=bea.BusinessEntityID
 inner join HumanResources.Department hdpt
 on hdpt.departmentId=emph.departmentID

 --7.

 select distinct GroupName
 from HumanResources.Department

 --8.

 select ph.StandardCost,sum(ph.StandardCost)as SumOfStandardCost,sum(pp.ListPrice) as SumOfListPRice
 from Production.ProductCostHistory ph,Production.Product pp
 group by ph.StandardCost

 --9.
 select  BusinessEntityID,datediff(YEAR,StartDate,EndDate)as YearOnRole
 from HumanResources.EmployeeDepartmentHistory

 --10.
 Select*
 from Sales.SalesPersonQuotaHistory

 select sum(SalesQuota)
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota

 --11.
 select Max(TaxRate) Max_taXrate
 from Sales.SalesTaxRate

 --12.

 select*from HumanResources.Employee
 select*from HumanResources.Department
 select*from HumanResources.EmployeeDepartmentHistory
 go
 create view task_12
 as
 select edh.DepartmentID,edh.BusinessEntityID,ShiftID,BirthDate,datediff(year,BirthDate,getdate()) Age
 from HumanResources.EmployeeDepartmentHistory edh
 join HumanResources.Employee emp
 on edh.BusinessEntityID=emp.BusinessEntityID
 join HumanResources.Department dpt
 on edh.DepartmentID=dpt.DepartmentID
 go

 --13.

 create view Name_age
 as
 select*from task_12
 go

 select*from Name_age

 --14.

 select count(*) No_OF_Rows
 from HumanResources.Department,HumanResources.Employee,HumanResources.EmployeeDepartmentHistory,HumanResources.EmployeePayHistory,HumanResources.JobCandidate,HumanResources.Shift
 
 --15.

 select max(Rate) MAxRate
 from HumanResources.Department dpt
 join HumanResources.EmployeeDepartmentHistory eph
 on dpt.DepartmentID=eph.DepartmentID
 join HumanResources.EmployeePayHistory ephs
 on eph.BusinessEntityID=ephs.BusinessEntityID

 --16.

 select FirstName,MiddleName,Title,AddressTypeID,per.businessentityID
 from Person.Person per
 left outer join Person.BusinessEntityAddress pb
 on per.BusinessEntityID=pb.BusinessEntityID
 where Title is not null

 --17.
 select ProductID,LocationID,Shelf 
 from Production.ProductInventory
 where ProductID >300 and ProductID <350 and LocationID like '%50%'

 --18.
 select pin.LocationID,Shelf,Name 
 from Production.ProductInventory pin
 join Production.Location pl
 on pin.LocationID = pl.LocationID

 --19.

 select AddressID,AddressLine1,AddressLine2,sp.StateProvinceID,StateProvinceCode,CountryRegionCode
 from Person.StateProvince sp
 join Person.Address pa
 on sp.StateProvinceID = pa.StateProvinceID

 --20.

 select currencycode,sum(subtotal)SumOFSUBTOTAL,TaxAmt 
 from Sales.SalesOrderHeader soh
 join Sales.SalesTerritory stt
 on soh.TerritoryID = stt.TerritoryID
 join Sales.CountryRegionCurrency crc
 on stt.CountryRegionCode=crc.CountryRegionCode
 group by CurrencyCode,TaxAmt