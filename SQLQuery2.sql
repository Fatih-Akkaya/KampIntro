--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers;

Select * from Customers where City='London'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by ProductName

Select * from Products order by CategoryId, ProductName

Select * from Products Where CategoryId=1 order by UnitPrice desc

Select count(*) Adet from Products where CategoryId=2

--UnitPrice 20 den büyük kategorilerideki ürün adedi 10 dan küçük kategorileri gruplayıp ürün sayılarını yazdırır
Select CategoryId, count(*) Adet from Products where UnitPrice>20 group by CategoryId having count(*)<10

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories on (Products.CategoryID=Categories.CategoryID)
where Products.UnitPrice>10

Select * from Products p left join [Order Details] od on p.ProductID=od.ProductID

--left join soldaki tablonun tamamını, sağdakilerle eşleşenlerin değerlerini eğer yoksa null olarak listeler
Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID

--Hiç sipariş vermemiş müşterilerin listesi
Select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null