select ContactName Adi, CompanyName Sirket, City Şehir from Customers

select * from Customers where City = 'London'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>20

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) from Products where CategoryID=3

select CategoryID, count(*) from Products group by CategoryID having count(*) <=10

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*) <=10

select Products.ProductID, Products.ProductName, Categories.CategoryID, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID where Products.UnitPrice>10

select * from Products P inner join [Order Details] OD
on p.ProductID = OD.ProductID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID 
where o.CustomerID is null