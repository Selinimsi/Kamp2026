Select CustomerID Id,CompanyName ŞirketAdı,Phone TelNo from Customers--Select komutu seçmemizi sağlar
Select * from Customers where City='London'
Select * from Customers where City='London' or City='Berlin'
Select * from Products where CategoryID=1 and UnitPrice>=20

Select * from Products order by ProductName 
Select * from Products order by UnitPrice desc
select CategoryID,COUNT(*) from Products group by CategoryID
select CategoryID,COUNT(*) from Products group by CategoryID having COUNT(*)<10
select CategoryID,COUNT(*) from Products where UnitPrice>20 group by CategoryID having COUNT(*)<10
